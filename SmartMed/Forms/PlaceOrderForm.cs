using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class PlaceOrderForm : Form
    {
        private readonly MedicineRepository _medicines = new MedicineRepository();
        private readonly OrderRepository _orders = new OrderRepository();

        private readonly List<OrderItem> _cart = new List<OrderItem>();

        private string _prescriptionSourcePath;

        public PlaceOrderForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(medicinesGrid);
            UiTheme.StyleGrid(cartGrid);
            RefreshMedicines();
            RefreshCart();
        }

        private void RefreshMedicines()
        {
            medicinesGrid.DataSource = null;
            medicinesGrid.DataSource = _medicines.GetAll()
                .Where(m => m.Stock > 0)
                .OrderBy(m => m.Name)
                .Select(m => new
                {
                    m.Id,
                    m.Name,
                    m.Category,
                    Price = m.DiscountedPrice(),
                    m.Stock,
                    Prescription = m.RequiresPrescription ? "Yes" : "No"
                })
                .ToList();

            if (medicinesGrid.Columns["Id"] != null)
            {
                medicinesGrid.Columns["Id"].Visible = false;
            }
            UiTheme.FormatMoneyColumns(medicinesGrid, "Price");
        }

        private void RefreshCart()
        {
            cartGrid.DataSource = null;
            cartGrid.DataSource = _cart
                .Select(i => new
                {
                    i.MedicineName,
                    Qty = i.Quantity,
                    UnitPrice = i.UnitPrice,
                    LineTotal = i.LineTotal
                })
                .ToList();

            UiTheme.FormatMoneyColumns(cartGrid, "UnitPrice", "LineTotal");

            decimal total = _cart.Sum(i => i.LineTotal);
            lblTotal.Text = "Total: " + total.ToString("C2");

            UpdatePrescriptionUi();
        }

        private void UpdatePrescriptionUi()
        {
            bool needsPrescription = CartRequiresPrescription();
            btnUpload.Visible = needsPrescription;
            lblPrescription.Visible = needsPrescription;

            if (!needsPrescription)
            {
                return;
            }

            if (string.IsNullOrEmpty(_prescriptionSourcePath))
            {
                lblPrescription.ForeColor = Color.FromArgb(219, 75, 75);
                lblPrescription.Text = "A prescription is required for one or more items.";
            }
            else
            {
                lblPrescription.ForeColor = Color.FromArgb(46, 158, 107);
                lblPrescription.Text = "Attached: " + Path.GetFileName(_prescriptionSourcePath);
            }
        }

        private bool CartRequiresPrescription()
        {
            foreach (OrderItem item in _cart)
            {
                Medicine medicine = _medicines.GetById(item.MedicineId);
                if (medicine != null && medicine.RequiresPrescription)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (medicinesGrid.CurrentRow == null)
            {
                MessageBox.Show("Select a medicine first.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(medicinesGrid.CurrentRow.Cells["Id"].Value);
            Medicine medicine = _medicines.GetById(id);
            if (medicine == null)
            {
                return;
            }

            int quantity = (int)numQuantity.Value;
            int alreadyInCart = _cart.Where(i => i.MedicineId == id).Sum(i => i.Quantity);

            if (quantity + alreadyInCart > medicine.Stock)
            {
                MessageBox.Show(
                    "Only " + medicine.Stock + " in stock (you already have " + alreadyInCart + " in the cart).",
                    "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrderItem existing = _cart.FirstOrDefault(i => i.MedicineId == id);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _cart.Add(new OrderItem
                {
                    MedicineId = medicine.Id,
                    MedicineName = medicine.Name,
                    Quantity = quantity,
                    UnitPrice = medicine.DiscountedPrice()
                });
            }

            RefreshCart();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (cartGrid.CurrentRow == null)
            {
                return;
            }

            int index = cartGrid.CurrentRow.Index;
            if (index >= 0 && index < _cart.Count)
            {
                _cart.RemoveAt(index);
                RefreshCart();
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Prescription files (*.pdf;*.png;*.jpg;*.jpeg)|*.pdf;*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _prescriptionSourcePath = dialog.FileName;
                    UpdatePrescriptionUi();
                }
            }
        }

        private void BtnPlace_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Customer customer = SessionContext.CurrentCustomer;
            if (customer == null)
            {
                MessageBox.Show("No customer is signed in.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (OrderItem item in _cart)
            {
                Medicine medicine = _medicines.GetById(item.MedicineId);
                if (medicine == null)
                {
                    MessageBox.Show(item.MedicineName + " is no longer available.", "SmartMed Pharmacy",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Quantity > medicine.Stock)
                {
                    MessageBox.Show("Not enough stock for " + medicine.Name + " (only " + medicine.Stock + " left).",
                        "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (CartRequiresPrescription() && string.IsNullOrEmpty(_prescriptionSourcePath))
            {
                MessageBox.Show("Please upload a prescription before placing this order.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string storedPrescriptionPath = null;
                if (CartRequiresPrescription() && !string.IsNullOrEmpty(_prescriptionSourcePath))
                {
                    storedPrescriptionPath = CopyPrescription(customer.Id);
                }

                Order order = new Order
                {
                    CustomerId = customer.Id,
                    OrderDate = DateTime.Now,
                    Status = OrderStatus.Pending,
                    Items = _cart.Select(i => new OrderItem
                    {
                        MedicineId = i.MedicineId,
                        MedicineName = i.MedicineName,
                        Quantity = i.Quantity,
                        UnitPrice = i.UnitPrice
                    }).ToList(),
                    PrescriptionFilePath = storedPrescriptionPath
                };
                _orders.Add(order);

                foreach (OrderItem item in _cart)
                {
                    Medicine medicine = _medicines.GetById(item.MedicineId);
                    medicine.Stock -= item.Quantity;
                    _medicines.Update(medicine);
                }

                MessageBox.Show(
                    "Order placed successfully!\nOrder #" + order.Id + " - Total " + order.TotalAmount.ToString("C2"),
                    "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cart.Clear();
                _prescriptionSourcePath = null;
                RefreshMedicines();
                RefreshCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not place the order:\n" + ex.Message, "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CopyPrescription(int customerId)
        {
            Directory.CreateDirectory(SeedData.PrescriptionsFolder);

            string extension = Path.GetExtension(_prescriptionSourcePath);
            string fileName = "cust" + customerId + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;
            string destination = Path.Combine(SeedData.PrescriptionsFolder, fileName);

            File.Copy(_prescriptionSourcePath, destination, true);
            return destination;
        }
    }
}
