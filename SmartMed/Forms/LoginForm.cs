using System;
using System.Windows.Forms;
using SmartMed.Models;
using SmartMed.Services;

namespace SmartMed.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        private const string EyeGlyph = "\uE7B3";
        private const string EyeOffGlyph = "\uED1A";

        public LoginForm()
        {
            InitializeComponent();
            ApplyPasswordVisibility(false);
        }

        private void BtnTogglePassword_Click(object sender, EventArgs e)
        {
            ApplyPasswordVisibility(txtPassword.UseSystemPasswordChar);
            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.TextLength;
        }

        private void ApplyPasswordVisibility(bool visible)
        {
            txtPassword.UseSystemPasswordChar = !visible;
            btnTogglePassword.Text = visible ? EyeOffGlyph : EyeGlyph;
            tipPassword.SetToolTip(btnTogglePassword, visible ? "Hide password" : "Show password");
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = _auth.LoginAdmin(txtUsername.Text, txtPassword.Text);
            if (admin == null)
            {
                lblStatus.Text = "Invalid administrator credentials.";
                return;
            }

            SessionContext.SignIn(admin);
            OpenDashboard(new AdminDashboardForm());
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = _auth.LoginCustomer(txtUsername.Text, txtPassword.Text);
            if (customer == null)
            {
                lblStatus.Text = "Invalid customer credentials.";
                return;
            }

            SessionContext.SignIn(customer);
            OpenDashboard(new CustomerDashboardForm());
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (RegisterForm register = new RegisterForm())
            {
                register.ShowDialog(this);
            }
        }

        private void OpenDashboard(Form dashboard)
        {
            lblStatus.Text = "";
            Hide();
            using (dashboard)
            {
                dashboard.ShowDialog(this);
            }

            SessionContext.SignOut();
            txtUsername.Clear();
            txtPassword.Clear();
            ApplyPasswordVisibility(false);
            txtUsername.Focus();
            Show();
        }
    }
}
