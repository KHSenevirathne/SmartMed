using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class ManageOrdersForm : Form
    {
        private readonly OrderRepository _orders = new OrderRepository();
        private readonly CustomerRepository _customers = new CustomerRepository();

        private int _selectedOrderId = 0;

        public ManageOrdersForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(ordersGrid);
            UiTheme.StyleGrid(itemsGrid);
            cmbStatus.Items.AddRange(new object[] { OrderStatus.Pending, OrderStatus.ReadyForPickup, OrderStatus.Delivered });
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            var customers = _customers.GetAll().ToList();

            ordersGrid.DataSource = null;
            ordersGrid.DataSource = _orders.GetAll()
                .OrderByDescending(o => o.OrderDate)
                .Select(o => new
                {
                    o.Id,
                    Date = o.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    Customer = customers.Where(c => c.Id == o.CustomerId)
                                        .Select(c => c.FullName)
                                        .FirstOrDefault() ?? "(unknown)",
                    Items = o.Items.Sum(i => i.Quantity),
                    Total = o.TotalAmount,
                    Status = o.Status.ToString(),
                    Prescription = string.IsNullOrEmpty(o.PrescriptionFilePath) ? "-" : "Yes"
                })
                .ToList();

            UiTheme.FormatMoneyColumns(ordersGrid, "Total");
        }

        private void OrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGrid.CurrentRow == null)
            {
                return;
            }
            object idValue = ordersGrid.CurrentRow.Cells["Id"].Value;
            if (idValue == null)
            {
                return;
            }

            _selectedOrderId = Convert.ToInt32(idValue);
            Order order = _orders.GetById(_selectedOrderId);
            if (order == null)
            {
                return;
            }

            cmbStatus.SelectedItem = order.Status;
            btnPrescription.Enabled = !string.IsNullOrEmpty(order.PrescriptionFilePath);

            itemsGrid.DataSource = null;
            itemsGrid.DataSource = order.Items
                .Select(i => new
                {
                    i.MedicineName,
                    i.Quantity,
                    UnitPrice = i.UnitPrice,
                    LineTotal = i.LineTotal
                })
                .ToList();

            UiTheme.FormatMoneyColumns(itemsGrid, "UnitPrice", "LineTotal");

            lblStatus.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == 0 || cmbStatus.SelectedItem == null)
            {
                lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
                lblStatus.Text = "Select an order and a status.";
                return;
            }

            Order order = _orders.GetById(_selectedOrderId);
            if (order == null)
            {
                return;
            }

            order.Status = (OrderStatus)cmbStatus.SelectedItem;
            try
            {
                _orders.Update(order);
                RefreshOrders();
                lblStatus.ForeColor = Color.FromArgb(46, 158, 107);
                lblStatus.Text = "Status updated.";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
                lblStatus.Text = "Could not update: " + ex.Message;
            }
        }

        private void BtnPrescription_Click(object sender, EventArgs e)
        {
            Order order = _orders.GetById(_selectedOrderId);
            if (order == null || string.IsNullOrEmpty(order.PrescriptionFilePath))
            {
                return;
            }

            try
            {
                if (File.Exists(order.PrescriptionFilePath))
                {
                    Process.Start(order.PrescriptionFilePath);
                }
                else
                {
                    MessageBox.Show("The prescription file could not be found:\n" + order.PrescriptionFilePath,
                        "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the prescription file:\n" + ex.Message,
                    "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
