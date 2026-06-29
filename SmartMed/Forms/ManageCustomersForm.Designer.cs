using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class ManageCustomersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private DataGridView grid;
        private Panel formPanel;
        private Label lblFormTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnUpdate;
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
            this.grid = new DataGridView();
            this.formPanel = new Panel();
            this.lblFormTitle = new Label();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.btnUpdate = new Button();
            this.btnClose = new Button();
            this.lblStatus = new Label();
            this.headerBar.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.header);
            this.headerBar.Location = new Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new Size(960, 56);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(20, 13);
            this.header.Name = "header";
            this.header.Size = new Size(500, 30);
            this.header.Text = "Manage Customers";
            //
            // grid
            //
            this.grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = Color.White;
            this.grid.Location = new Point(20, 76);
            this.grid.Name = "grid";
            this.grid.Size = new Size(596, 504);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            //
            // formPanel
            //
            this.formPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.formPanel.BackColor = Color.White;
            this.formPanel.Controls.Add(this.lblFormTitle);
            this.formPanel.Controls.Add(this.lblFullName);
            this.formPanel.Controls.Add(this.txtFullName);
            this.formPanel.Controls.Add(this.lblEmail);
            this.formPanel.Controls.Add(this.txtEmail);
            this.formPanel.Controls.Add(this.lblPhone);
            this.formPanel.Controls.Add(this.txtPhone);
            this.formPanel.Controls.Add(this.lblAddress);
            this.formPanel.Controls.Add(this.txtAddress);
            this.formPanel.Controls.Add(this.btnUpdate);
            this.formPanel.Controls.Add(this.btnClose);
            this.formPanel.Controls.Add(this.lblStatus);
            this.formPanel.Location = new Point(632, 76);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new Size(304, 392);
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.FromArgb(31, 42, 68);
            this.lblFormTitle.Location = new Point(16, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new Size(272, 24);
            this.lblFormTitle.Text = "Edit contact details";
            //
            // lblFullName
            //
            this.lblFullName.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblFullName.Location = new Point(16, 48);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(272, 16);
            this.lblFullName.Text = "Full name";
            //
            // txtFullName
            //
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.Location = new Point(16, 66);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(272, 26);
            //
            // lblEmail
            //
            this.lblEmail.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblEmail.Location = new Point(16, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(272, 16);
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Location = new Point(16, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(272, 26);
            //
            // lblPhone
            //
            this.lblPhone.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPhone.Location = new Point(16, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(272, 16);
            this.lblPhone.Text = "Phone";
            //
            // txtPhone
            //
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.Location = new Point(16, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(272, 26);
            //
            // lblAddress
            //
            this.lblAddress.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblAddress.Location = new Point(16, 204);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(272, 16);
            this.lblAddress.Text = "Address";
            //
            // txtAddress
            //
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Location = new Point(16, 222);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(272, 26);
            //
            // btnUpdate
            //
            this.btnUpdate.BackColor = Color.FromArgb(64, 84, 178);
            this.btnUpdate.Cursor = Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Location = new Point(16, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(272, 38);
            this.btnUpdate.Text = "Update customer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            //
            // btnClose
            //
            this.btnClose.BackColor = Color.White;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClose.Location = new Point(16, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(272, 34);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            this.lblStatus.Location = new Point(16, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(272, 36);
            //
            // ManageCustomersForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(960, 600);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(880, 580);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.formPanel);
            this.Name = "ManageCustomersForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Manage Customers";
            this.headerBar.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
