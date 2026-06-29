using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class ManageCustomersForm : Form
    {
        private readonly CustomerRepository _repo = new CustomerRepository();

        private int _selectedId = 0;

        public ManageCustomersForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            grid.DataSource = null;
            grid.DataSource = _repo.GetAll()
                .OrderBy(c => c.FullName)
                .Select(c => new
                {
                    c.Id,
                    c.FullName,
                    c.Username,
                    c.Email,
                    c.Phone,
                    c.Address,
                    Registered = c.DateRegistered.ToString("yyyy-MM-dd")
                })
                .ToList();

            if (grid.Columns["Id"] != null)
            {
                grid.Columns["Id"].Visible = false;
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null)
            {
                return;
            }

            object idValue = grid.CurrentRow.Cells["Id"].Value;
            if (idValue == null)
            {
                return;
            }

            int id = Convert.ToInt32(idValue);
            Customer customer = _repo.GetById(id);
            if (customer == null)
            {
                return;
            }

            _selectedId = customer.Id;
            txtFullName.Text = customer.FullName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
            lblStatus.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                Fail("Select a customer in the list first.");
                return;
            }
            if (!Validator.IsNotEmpty(txtFullName.Text))
            {
                Fail("Full name is required.");
                return;
            }
            if (!Validator.IsValidEmail(txtEmail.Text))
            {
                Fail("Please enter a valid email address.");
                return;
            }

            Customer customer = _repo.GetById(_selectedId);
            if (customer == null)
            {
                Fail("That customer no longer exists.");
                return;
            }

            customer.FullName = txtFullName.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();
            customer.Address = txtAddress.Text.Trim();

            try
            {
                _repo.Update(customer);
                RefreshGrid();
                lblStatus.ForeColor = Color.FromArgb(46, 158, 107);
                lblStatus.Text = "Customer updated.";
            }
            catch (Exception ex)
            {
                Fail("Could not update customer: " + ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fail(string message)
        {
            lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            lblStatus.Text = message;
        }
    }
}
