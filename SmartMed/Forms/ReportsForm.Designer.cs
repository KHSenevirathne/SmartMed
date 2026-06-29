using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Button btnSales;
        private Button btnStock;
        private ComboBox cmbCustomers;
        private Button btnHistory;
        private Button btnExport;
        private Label lblTitle;
        private DataGridView grid;
        private Button btnClose;

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
            this.btnSales = new Button();
            this.btnStock = new Button();
            this.cmbCustomers = new ComboBox();
            this.btnHistory = new Button();
            this.btnExport = new Button();
            this.lblTitle = new Label();
            this.grid = new DataGridView();
            this.btnClose = new Button();
            this.headerBar.SuspendLayout();
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
            this.headerBar.Size = new Size(940, 56);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(20, 13);
            this.header.Name = "header";
            this.header.Size = new Size(300, 30);
            this.header.Text = "Reports";
            //
            // btnSales
            //
            this.btnSales.BackColor = Color.FromArgb(64, 84, 178);
            this.btnSales.Cursor = Cursors.Hand;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnSales.FlatStyle = FlatStyle.Flat;
            this.btnSales.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSales.ForeColor = Color.White;
            this.btnSales.Location = new Point(20, 72);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new Size(150, 34);
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.BtnSales_Click);
            //
            // btnStock
            //
            this.btnStock.BackColor = Color.FromArgb(64, 84, 178);
            this.btnStock.Cursor = Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnStock.FlatStyle = FlatStyle.Flat;
            this.btnStock.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnStock.ForeColor = Color.White;
            this.btnStock.Location = new Point(178, 72);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new Size(150, 34);
            this.btnStock.Text = "Stock Report";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.BtnStock_Click);
            //
            // cmbCustomers
            //
            this.cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCustomers.FlatStyle = FlatStyle.Flat;
            this.cmbCustomers.Location = new Point(340, 75);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new Size(230, 26);
            //
            // btnHistory
            //
            this.btnHistory.BackColor = Color.FromArgb(64, 84, 178);
            this.btnHistory.Cursor = Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnHistory.FlatStyle = FlatStyle.Flat;
            this.btnHistory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnHistory.ForeColor = Color.White;
            this.btnHistory.Location = new Point(582, 72);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new Size(160, 34);
            this.btnHistory.Text = "Customer History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            //
            // btnExport
            //
            this.btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnExport.BackColor = Color.FromArgb(46, 158, 107);
            this.btnExport.Cursor = Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 138, 92);
            this.btnExport.FlatStyle = FlatStyle.Flat;
            this.btnExport.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnExport.ForeColor = Color.White;
            this.btnExport.Location = new Point(770, 72);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new Size(150, 34);
            this.btnExport.Text = "Export to CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            //
            // lblTitle
            //
            this.lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(31, 42, 68);
            this.lblTitle.Location = new Point(20, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(900, 26);
            //
            // grid
            //
            this.grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = Color.White;
            this.grid.Location = new Point(20, 152);
            this.grid.Name = "grid";
            this.grid.Size = new Size(900, 396);
            //
            // btnClose
            //
            this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClose.BackColor = Color.White;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClose.Location = new Point(820, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // ReportsForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(940, 600);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(860, 560);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnClose);
            this.Name = "ReportsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Reports";
            this.headerBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
