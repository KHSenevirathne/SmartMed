using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class ManageMedicinesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private DataGridView grid;
        private Label legend;
        private Panel formPanel;
        private Label lblFormTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblDosage;
        private TextBox txtDosage;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblExpiry;
        private DateTimePicker dtExpiry;
        private CheckBox chkPrescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
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
            this.legend = new Label();
            this.formPanel = new Panel();
            this.lblFormTitle = new Label();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblCategory = new Label();
            this.txtCategory = new TextBox();
            this.lblDosage = new Label();
            this.txtDosage = new TextBox();
            this.lblPrice = new Label();
            this.txtPrice = new TextBox();
            this.lblStock = new Label();
            this.txtStock = new TextBox();
            this.lblSupplier = new Label();
            this.txtSupplier = new TextBox();
            this.lblDiscount = new Label();
            this.txtDiscount = new TextBox();
            this.lblExpiry = new Label();
            this.dtExpiry = new DateTimePicker();
            this.chkPrescription = new CheckBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
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
            this.headerBar.Size = new Size(1000, 56);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(20, 13);
            this.header.Name = "header";
            this.header.Size = new Size(500, 30);
            this.header.Text = "Manage Medicines";
            //
            // grid
            //
            this.grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = Color.White;
            this.grid.Location = new Point(20, 76);
            this.grid.Name = "grid";
            this.grid.Size = new Size(600, 520);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            //
            // legend
            //
            this.legend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.legend.AutoSize = false;
            this.legend.ForeColor = Color.FromArgb(232, 169, 59);
            this.legend.Location = new Point(20, 602);
            this.legend.Name = "legend";
            this.legend.Size = new Size(560, 20);
            this.legend.Text = "Rows highlighted in amber expire within 30 days.";
            //
            // formPanel
            //
            this.formPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.formPanel.BackColor = Color.White;
            this.formPanel.Controls.Add(this.lblFormTitle);
            this.formPanel.Controls.Add(this.lblName);
            this.formPanel.Controls.Add(this.txtName);
            this.formPanel.Controls.Add(this.lblCategory);
            this.formPanel.Controls.Add(this.txtCategory);
            this.formPanel.Controls.Add(this.lblDosage);
            this.formPanel.Controls.Add(this.txtDosage);
            this.formPanel.Controls.Add(this.lblPrice);
            this.formPanel.Controls.Add(this.txtPrice);
            this.formPanel.Controls.Add(this.lblStock);
            this.formPanel.Controls.Add(this.txtStock);
            this.formPanel.Controls.Add(this.lblSupplier);
            this.formPanel.Controls.Add(this.txtSupplier);
            this.formPanel.Controls.Add(this.lblDiscount);
            this.formPanel.Controls.Add(this.txtDiscount);
            this.formPanel.Controls.Add(this.lblExpiry);
            this.formPanel.Controls.Add(this.dtExpiry);
            this.formPanel.Controls.Add(this.chkPrescription);
            this.formPanel.Controls.Add(this.btnAdd);
            this.formPanel.Controls.Add(this.btnUpdate);
            this.formPanel.Controls.Add(this.btnDelete);
            this.formPanel.Controls.Add(this.btnClear);
            this.formPanel.Controls.Add(this.btnClose);
            this.formPanel.Controls.Add(this.lblStatus);
            this.formPanel.Location = new Point(636, 76);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new Size(344, 520);
            //
            // lblFormTitle
            //
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblFormTitle.ForeColor = Color.FromArgb(31, 42, 68);
            this.lblFormTitle.Location = new Point(16, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new Size(312, 24);
            this.lblFormTitle.Text = "Medicine details";
            //
            // lblName
            //
            this.lblName.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblName.Location = new Point(16, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(312, 16);
            this.lblName.Text = "Name";
            //
            // txtName
            //
            this.txtName.BorderStyle = BorderStyle.FixedSingle;
            this.txtName.Location = new Point(16, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(312, 26);
            //
            // lblCategory
            //
            this.lblCategory.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblCategory.Location = new Point(16, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(312, 16);
            this.lblCategory.Text = "Category";
            //
            // txtCategory
            //
            this.txtCategory.BorderStyle = BorderStyle.FixedSingle;
            this.txtCategory.Location = new Point(16, 118);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new Size(312, 26);
            //
            // lblDosage
            //
            this.lblDosage.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblDosage.Location = new Point(16, 152);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new Size(312, 16);
            this.lblDosage.Text = "Dosage";
            //
            // txtDosage
            //
            this.txtDosage.BorderStyle = BorderStyle.FixedSingle;
            this.txtDosage.Location = new Point(16, 170);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new Size(312, 26);
            //
            // lblPrice
            //
            this.lblPrice.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblPrice.Location = new Point(16, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(150, 16);
            this.lblPrice.Text = "Price";
            //
            // txtPrice
            //
            this.txtPrice.BorderStyle = BorderStyle.FixedSingle;
            this.txtPrice.Location = new Point(16, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new Size(150, 26);
            //
            // lblStock
            //
            this.lblStock.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblStock.Location = new Point(178, 204);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new Size(150, 16);
            this.lblStock.Text = "Stock";
            //
            // txtStock
            //
            this.txtStock.BorderStyle = BorderStyle.FixedSingle;
            this.txtStock.Location = new Point(178, 222);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new Size(150, 26);
            //
            // lblSupplier
            //
            this.lblSupplier.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblSupplier.Location = new Point(16, 256);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new Size(312, 16);
            this.lblSupplier.Text = "Supplier";
            //
            // txtSupplier
            //
            this.txtSupplier.BorderStyle = BorderStyle.FixedSingle;
            this.txtSupplier.Location = new Point(16, 274);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new Size(312, 26);
            //
            // lblDiscount
            //
            this.lblDiscount.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblDiscount.Location = new Point(16, 308);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new Size(150, 16);
            this.lblDiscount.Text = "Discount %";
            //
            // txtDiscount
            //
            this.txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            this.txtDiscount.Location = new Point(16, 326);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new Size(150, 26);
            //
            // lblExpiry
            //
            this.lblExpiry.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblExpiry.Location = new Point(178, 308);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new Size(150, 16);
            this.lblExpiry.Text = "Expiry date";
            //
            // dtExpiry
            //
            this.dtExpiry.Format = DateTimePickerFormat.Short;
            this.dtExpiry.Location = new Point(178, 326);
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Size = new Size(150, 26);
            //
            // chkPrescription
            //
            this.chkPrescription.ForeColor = Color.FromArgb(51, 65, 92);
            this.chkPrescription.Location = new Point(16, 364);
            this.chkPrescription.Name = "chkPrescription";
            this.chkPrescription.Size = new Size(312, 24);
            this.chkPrescription.Text = "Requires prescription";
            //
            // btnAdd
            //
            this.btnAdd.BackColor = Color.FromArgb(46, 158, 107);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 138, 92);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(16, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(95, 38);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.btnUpdate.Location = new Point(118, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(95, 38);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = Color.FromArgb(219, 75, 75);
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(193, 62, 62);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(220, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(108, 38);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.BackColor = Color.White;
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClear.Location = new Point(16, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(150, 36);
            this.btnClear.Text = "Clear / New";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.btnClose.Location = new Point(178, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(150, 36);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = Color.FromArgb(219, 75, 75);
            this.lblStatus.Location = new Point(16, 490);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(312, 26);
            //
            // ManageMedicinesForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(1000, 632);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1016, 672);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.formPanel);
            this.Name = "ManageMedicinesForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Manage Medicines";
            this.headerBar.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
