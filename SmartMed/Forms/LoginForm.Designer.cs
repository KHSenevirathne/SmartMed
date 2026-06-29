using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel brandPanel;
        private Label brandTitle;
        private Label brandSubtitle;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Button btnAdmin;
        private Button btnCustomer;
        private Label lblOr;
        private Button btnRegister;
        private Label lblStatus;
        private Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.brandPanel = new Panel();
            this.brandTitle = new Label();
            this.brandSubtitle = new Label();
            this.lblUser = new Label();
            this.txtUsername = new TextBox();
            this.lblPass = new Label();
            this.txtPassword = new TextBox();
            this.btnAdmin = new Button();
            this.btnCustomer = new Button();
            this.lblOr = new Label();
            this.btnRegister = new Button();
            this.lblStatus = new Label();
            this.lblHint = new Label();
            this.brandPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // brandPanel
            //
            this.brandPanel.BackColor = Color.FromArgb(31, 42, 68);
            this.brandPanel.Controls.Add(this.brandTitle);
            this.brandPanel.Controls.Add(this.brandSubtitle);
            this.brandPanel.Location = new Point(0, 0);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new Size(440, 150);
            //
            // brandTitle
            //
            this.brandTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.brandTitle.ForeColor = Color.White;
            this.brandTitle.Location = new Point(20, 44);
            this.brandTitle.Name = "brandTitle";
            this.brandTitle.Size = new Size(400, 40);
            this.brandTitle.Text = "SmartMed";
            this.brandTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // brandSubtitle
            //
            this.brandSubtitle.Font = new Font("Segoe UI", 10F);
            this.brandSubtitle.ForeColor = Color.FromArgb(160, 170, 195);
            this.brandSubtitle.Location = new Point(20, 88);
            this.brandSubtitle.Name = "brandSubtitle";
            this.brandSubtitle.Size = new Size(400, 22);
            this.brandSubtitle.Text = "Pharmacy Management System";
            this.brandSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblUser
            //
            this.lblUser.Font = new Font("Segoe UI", 9.5F);
            this.lblUser.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblUser.Location = new Point(60, 178);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(320, 18);
            this.lblUser.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.Font = new Font("Segoe UI", 11F);
            this.txtUsername.Location = new Point(60, 198);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(320, 30);
            //
            // lblPass
            //
            this.lblPass.Font = new Font("Segoe UI", 9.5F);
            this.lblPass.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPass.Location = new Point(60, 240);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new Size(320, 18);
            this.lblPass.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(60, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(320, 30);
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // btnAdmin
            //
            this.btnAdmin.BackColor = Color.FromArgb(64, 84, 178);
            this.btnAdmin.Cursor = Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnAdmin.FlatStyle = FlatStyle.Flat;
            this.btnAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdmin.ForeColor = Color.White;
            this.btnAdmin.Location = new Point(60, 312);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new Size(155, 42);
            this.btnAdmin.Text = "Admin Login";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            //
            // btnCustomer
            //
            this.btnCustomer.BackColor = Color.FromArgb(64, 84, 178);
            this.btnCustomer.Cursor = Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnCustomer.FlatStyle = FlatStyle.Flat;
            this.btnCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCustomer.ForeColor = Color.White;
            this.btnCustomer.Location = new Point(225, 312);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new Size(155, 42);
            this.btnCustomer.Text = "Customer Login";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            //
            // lblOr
            //
            this.lblOr.Font = new Font("Segoe UI", 9F);
            this.lblOr.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblOr.Location = new Point(60, 366);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new Size(320, 18);
            this.lblOr.Text = "New here?";
            this.lblOr.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnRegister
            //
            this.btnRegister.BackColor = Color.White;
            this.btnRegister.Cursor = Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnRegister.FlatAppearance.BorderSize = 1;
            this.btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 10F);
            this.btnRegister.ForeColor = Color.FromArgb(64, 84, 178);
            this.btnRegister.Location = new Point(60, 388);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(320, 40);
            this.btnRegister.Text = "Create a customer account";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            //
            // lblStatus
            //
            this.lblStatus.Font = new Font("Segoe UI", 9.5F);
            this.lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            this.lblStatus.Location = new Point(40, 438);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(360, 40);
            this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblHint
            //
            this.lblHint.Font = new Font("Segoe UI", 8.5F);
            this.lblHint.ForeColor = Color.FromArgb(160, 168, 184);
            this.lblHint.Location = new Point(40, 500);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new Size(360, 20);
            this.lblHint.Text = "Demo admin:  admin / Admin@123";
            this.lblHint.TextAlign = ContentAlignment.MiddleCenter;
            //
            // LoginForm
            //
            this.AcceptButton = this.btnAdmin;
            this.BackColor = Color.White;
            this.ClientSize = new Size(440, 530);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.brandPanel);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHint);
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Login";
            this.brandPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
