using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label title;
        private Label subtitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblStatus;

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
            this.headerBar = new Panel();
            this.title = new Label();
            this.subtitle = new Label();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblConfirm = new Label();
            this.txtConfirm = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.lblStatus = new Label();
            this.headerBar.SuspendLayout();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.title);
            this.headerBar.Controls.Add(this.subtitle);
            this.headerBar.Location = new Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new Size(440, 72);
            //
            // title
            //
            this.title.AutoSize = false;
            this.title.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.title.ForeColor = Color.White;
            this.title.Location = new Point(24, 13);
            this.title.Name = "title";
            this.title.Size = new Size(400, 30);
            this.title.Text = "Create your account";
            //
            // subtitle
            //
            this.subtitle.AutoSize = false;
            this.subtitle.Font = new Font("Segoe UI", 9F);
            this.subtitle.ForeColor = Color.FromArgb(160, 170, 195);
            this.subtitle.Location = new Point(26, 44);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new Size(400, 18);
            this.subtitle.Text = "Join SmartMed in a few seconds";
            //
            // lblFullName
            //
            this.lblFullName.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblFullName.Location = new Point(30, 86);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(380, 16);
            this.lblFullName.Text = "Full name";
            //
            // txtFullName
            //
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.Location = new Point(30, 104);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(380, 26);
            //
            // lblEmail
            //
            this.lblEmail.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblEmail.Location = new Point(30, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(380, 16);
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Location = new Point(30, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(380, 26);
            //
            // lblPhone
            //
            this.lblPhone.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPhone.Location = new Point(30, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(380, 16);
            this.lblPhone.Text = "Phone";
            //
            // txtPhone
            //
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.Location = new Point(30, 212);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(380, 26);
            //
            // lblAddress
            //
            this.lblAddress.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblAddress.Location = new Point(30, 248);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(380, 16);
            this.lblAddress.Text = "Address";
            //
            // txtAddress
            //
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Location = new Point(30, 266);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(380, 26);
            //
            // lblUsername
            //
            this.lblUsername.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblUsername.Location = new Point(30, 302);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(380, 16);
            this.lblUsername.Text = "Username";
            //
            // txtUsername
            //
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.Location = new Point(30, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(380, 26);
            //
            // lblPassword
            //
            this.lblPassword.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPassword.Location = new Point(30, 356);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(380, 16);
            this.lblPassword.Text = "Password (min 6 characters)";
            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Location = new Point(30, 374);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(380, 26);
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            this.lblConfirm.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblConfirm.Location = new Point(30, 410);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new Size(380, 16);
            this.lblConfirm.Text = "Confirm password";
            //
            // txtConfirm
            //
            this.txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            this.txtConfirm.Location = new Point(30, 428);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new Size(380, 26);
            this.txtConfirm.UseSystemPasswordChar = true;
            //
            // btnRegister
            //
            this.btnRegister.BackColor = Color.FromArgb(64, 84, 178);
            this.btnRegister.Cursor = Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new Point(30, 470);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(185, 40);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor = Color.White;
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnCancel.Location = new Point(225, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(185, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            this.lblStatus.Location = new Point(30, 516);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(380, 40);
            //
            // RegisterForm
            //
            this.AcceptButton = this.btnRegister;
            this.BackColor = Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new Size(440, 572);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStatus);
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Register";
            this.headerBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
