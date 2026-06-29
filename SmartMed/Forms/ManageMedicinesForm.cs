using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class ManageMedicinesForm : Form
    {
        private readonly MedicineRepository _repo = new MedicineRepository();

        private int _selectedId = 0;

        public ManageMedicinesForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            grid.DataSource = null;
            grid.DataSource = _repo.GetAll().OrderBy(m => m.Name).ToList();

            if (grid.Columns["Id"] != null)
            {
                grid.Columns["Id"].Visible = false;
            }
            UiTheme.FormatMoneyColumns(grid, "Price");

            foreach (DataGridViewRow row in grid.Rows)
            {
                Medicine medicine = row.DataBoundItem as Medicine;
                if (medicine != null && medicine.IsNearExpiry())
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(146, 100, 20);
                }
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null)
            {
                return;
            }
            Medicine medicine = grid.CurrentRow.DataBoundItem as Medicine;
            if (medicine == null)
            {
                return;
            }

            _selectedId = medicine.Id;
            txtName.Text = medicine.Name;
            txtCategory.Text = medicine.Category;
            txtDosage.Text = medicine.Dosage;
            txtPrice.Text = medicine.Price.ToString("0.00");
            txtStock.Text = medicine.Stock.ToString();
            txtSupplier.Text = medicine.Supplier;
            txtDiscount.Text = medicine.DiscountPercent.ToString("0.##");
            dtExpiry.Value = medicine.ExpiryDate;
            chkPrescription.Checked = medicine.RequiresPrescription;
            lblStatus.Text = "";
        }

        private bool TryReadInputs(out Medicine result)
        {
            result = null;

            if (!Validator.IsNotEmpty(txtName.Text)) { Fail("Name is required."); return false; }
            if (!Validator.IsNotEmpty(txtCategory.Text)) { Fail("Category is required."); return false; }
            if (!Validator.IsPositiveDecimal(txtPrice.Text)) { Fail("Price must be a positive number."); return false; }
            if (!Validator.IsNonNegativeInt(txtStock.Text)) { Fail("Stock must be zero or a positive whole number."); return false; }

            decimal discount = 0m;
            if (Validator.IsNotEmpty(txtDiscount.Text))
            {
                if (!Validator.TryParseDecimal(txtDiscount.Text, out discount) || discount < 0m || discount > 100m)
                {
                    Fail("Discount must be a number between 0 and 100.");
                    return false;
                }
            }

            decimal price;
            int stock;
            Validator.TryParseDecimal(txtPrice.Text, out price);
            Validator.TryParseInt(txtStock.Text, out stock);

            result = new Medicine
            {
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Dosage = txtDosage.Text.Trim(),
                Price = price,
                Stock = stock,
                Supplier = txtSupplier.Text.Trim(),
                DiscountPercent = discount,
                ExpiryDate = dtExpiry.Value.Date,
                RequiresPrescription = chkPrescription.Checked
            };
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Medicine medicine;
            if (!TryReadInputs(out medicine))
            {
                return;
            }

            try
            {
                _repo.Add(medicine);
                RefreshGrid();
                ClearInputs();
                Succeed("Medicine added.");
            }
            catch (Exception ex)
            {
                Fail("Could not add medicine: " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                Fail("Select a medicine in the list first.");
                return;
            }

            Medicine medicine;
            if (!TryReadInputs(out medicine))
            {
                return;
            }

            medicine.Id = _selectedId;
            try
            {
                _repo.Update(medicine);
                RefreshGrid();
                Succeed("Medicine updated.");
            }
            catch (Exception ex)
            {
                Fail("Could not update medicine: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                Fail("Select a medicine in the list first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete the selected medicine?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _repo.Delete(_selectedId);
                RefreshGrid();
                ClearInputs();
                Succeed("Medicine deleted.");
            }
            catch (Exception ex)
            {
                Fail("Could not delete medicine: " + ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearInputs()
        {
            _selectedId = 0;
            txtName.Clear();
            txtCategory.Clear();
            txtDosage.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtSupplier.Clear();
            txtDiscount.Clear();
            dtExpiry.Value = DateTime.Now.Date.AddMonths(12);
            chkPrescription.Checked = false;
            lblStatus.Text = "";
            grid.ClearSelection();
        }

        private void Succeed(string message)
        {
            lblStatus.ForeColor = Color.FromArgb(46, 158, 107);
            lblStatus.Text = message;
        }

        private void Fail(string message)
        {
            lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            lblStatus.Text = message;
        }
    }
}
