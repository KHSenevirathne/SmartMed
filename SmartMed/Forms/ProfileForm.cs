using System;
using System.Drawing;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly CustomerRepository _repo = new CustomerRepository();

        public ProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            Customer customer = SessionContext.CurrentCustomer;
            if (customer == null)
            {
                return;
            }
            txtFullName.Text = customer.FullName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Customer current = SessionContext.CurrentCustomer;
            if (current == null)
            {
                Fail("No customer is signed in.");
                return;
            }

            if (!Validator.IsNotEmpty(txtFullName.Text)) { Fail("Full name is required."); return; }
            if (!Validator.IsValidEmail(txtEmail.Text)) { Fail("Please enter a valid email address."); return; }
            if (!Validator.IsNotEmpty(txtPhone.Text)) { Fail("Phone is required."); return; }
            if (!Validator.IsNotEmpty(txtAddress.Text)) { Fail("Address is required."); return; }

            bool changingPassword = Validator.IsNotEmpty(txtNewPassword.Text) || Validator.IsNotEmpty(txtConfirm.Text);
            if (changingPassword)
            {
                if (!Validator.IsValidPassword(txtNewPassword.Text))
                {
                    Fail("New password must be at least 6 characters.");
                    return;
                }
                if (txtNewPassword.Text != txtConfirm.Text)
                {
                    Fail("The new passwords do not match.");
                    return;
                }
            }

            Customer stored = _repo.GetById(current.Id);
            if (stored == null)
            {
                Fail("Your account could not be found.");
                return;
            }

            stored.FullName = txtFullName.Text.Trim();
            stored.Email = txtEmail.Text.Trim();
            stored.Phone = txtPhone.Text.Trim();
            stored.Address = txtAddress.Text.Trim();
            if (changingPassword)
            {
                stored.PasswordHash = PasswordHasher.Hash(txtNewPassword.Text);
            }

            try
            {
                _repo.Update(stored);

                current.FullName = stored.FullName;
                current.Email = stored.Email;
                current.Phone = stored.Phone;
                current.Address = stored.Address;
                current.PasswordHash = stored.PasswordHash;

                txtNewPassword.Clear();
                txtConfirm.Clear();

                lblStatus.ForeColor = Color.FromArgb(46, 158, 107);
                lblStatus.Text = "Your profile has been updated.";
            }
            catch (Exception ex)
            {
                Fail("Could not save your profile: " + ex.Message);
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
