using System;
using System.Windows.Forms;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!Validator.IsNotEmpty(txtFullName.Text))
            {
                Fail("Please enter your full name."); return;
            }
            if (!Validator.IsValidEmail(txtEmail.Text))
            {
                Fail("Please enter a valid email address."); return;
            }
            if (!Validator.IsNotEmpty(txtPhone.Text))
            {
                Fail("Please enter a phone number."); return;
            }
            if (!Validator.IsNotEmpty(txtAddress.Text))
            {
                Fail("Please enter an address."); return;
            }
            if (!Validator.IsNotEmpty(txtUsername.Text))
            {
                Fail("Please choose a username."); return;
            }
            if (!Validator.IsValidPassword(txtPassword.Text))
            {
                Fail("Password must be at least 6 characters."); return;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                Fail("Passwords do not match."); return;
            }
            if (_auth.UsernameExists(txtUsername.Text))
            {
                Fail("That username is already taken."); return;
            }
            if (_auth.EmailExists(txtEmail.Text))
            {
                Fail("That email is already registered."); return;
            }
            if (_auth.PhoneExists(txtPhone.Text))
            {
                Fail("That phone number is already registered."); return;
            }

            try
            {
                _auth.RegisterCustomer(
                    txtFullName.Text, txtEmail.Text, txtPhone.Text,
                    txtAddress.Text, txtUsername.Text, txtPassword.Text);

                MessageBox.Show(
                    "Registration successful! You can now log in as a customer.",
                    "SmartMed Pharmacy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Fail("Could not register: " + ex.Message);
            }
        }

        private void Fail(string message)
        {
            lblStatus.Text = message;
        }
    }
}
