using System;
using System.Windows.Forms;
using SmartMed.Models;
using SmartMed.Services;

namespace SmartMed.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
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
            txtUsername.Focus();
            Show();
        }
    }
}
