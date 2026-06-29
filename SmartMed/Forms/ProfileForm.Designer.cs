using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label subtitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label note;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnClose;
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
            this.header = new Label();
            this.subtitle = new Label();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.note = new Label();
            this.lblNewPassword = new Label();
            this.txtNewPassword = new TextBox();
            this.lblConfirm = new Label();
            this.txtConfirm = new TextBox();
            this.btnSave = new Button();
            this.btnClose = new Button();
            this.lblStatus = new Label();
            this.headerBar.SuspendLayout();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.header);
            this.headerBar.Controls.Add(this.subtitle);
            this.headerBar.Location = new Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new Size(440, 72);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(24, 13);
            this.header.Name = "header";
            this.header.Size = new Size(400, 30);
            this.header.Text = "My Profile";
            //
            // subtitle
            //
            this.subtitle.AutoSize = false;
            this.subtitle.Font = new Font("Segoe UI", 9F);
            this.subtitle.ForeColor = Color.FromArgb(160, 170, 195);
            this.subtitle.Location = new Point(26, 44);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new Size(400, 18);
            this.subtitle.Text = "Update your details and password";
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
            this.lblEmail.Location = new Point(30, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(380, 16);
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Location = new Point(30, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(380, 26);
            //
            // lblPhone
            //
            this.lblPhone.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPhone.Location = new Point(30, 190);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(380, 16);
            this.lblPhone.Text = "Phone";
            //
            // txtPhone
            //
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.Location = new Point(30, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(380, 26);
            //
            // lblAddress
            //
            this.lblAddress.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblAddress.Location = new Point(30, 242);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(380, 16);
            this.lblAddress.Text = "Address";
            //
            // txtAddress
            //
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Location = new Point(30, 260);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(380, 26);
            //
            // note
            //
            this.note.ForeColor = Color.FromArgb(138, 147, 166);
            this.note.Location = new Point(30, 296);
            this.note.Name = "note";
            this.note.Size = new Size(380, 18);
            this.note.Text = "Leave the password fields blank to keep your current password.";
            //
            // lblNewPassword
            //
            this.lblNewPassword.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblNewPassword.Location = new Point(30, 320);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new Size(380, 16);
            this.lblNewPassword.Text = "New password";
            //
            // txtNewPassword
            //
            this.txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtNewPassword.Location = new Point(30, 338);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new Size(380, 26);
            this.txtNewPassword.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            this.lblConfirm.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblConfirm.Location = new Point(30, 372);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new Size(380, 16);
            this.lblConfirm.Text = "Confirm new password";
            //
            // txtConfirm
            //
            this.txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            this.txtConfirm.Location = new Point(30, 390);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new Size(380, 26);
            this.txtConfirm.UseSystemPasswordChar = true;
            //
            // btnSave
            //
            this.btnSave.BackColor = Color.FromArgb(64, 84, 178);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Location = new Point(30, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(185, 40);
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            //
            // btnClose
            //
            this.btnClose.BackColor = Color.White;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 10F);
            this.btnClose.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClose.Location = new Point(225, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(185, 40);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.Location = new Point(30, 478);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(380, 36);
            //
            // ProfileForm
            //
            this.AcceptButton = this.btnSave;
            this.BackColor = Color.White;
            this.ClientSize = new Size(440, 534);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.note);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Name = "ProfileForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - My Profile";
            this.headerBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
