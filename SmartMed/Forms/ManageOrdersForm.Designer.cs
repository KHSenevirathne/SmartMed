using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class ManageOrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label ordersLabel;
        private DataGridView ordersGrid;
        private Label itemsLabel;
        private DataGridView itemsGrid;
        private Panel actionPanel;
        private Label lblSet;
        private ComboBox cmbStatus;
        private Button btnUpdate;
        private Button btnPrescription;
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
            this.ordersLabel = new Label();
            this.ordersGrid = new DataGridView();
            this.itemsLabel = new Label();
            this.itemsGrid = new DataGridView();
            this.actionPanel = new Panel();
            this.lblSet = new Label();
            this.cmbStatus = new ComboBox();
            this.btnUpdate = new Button();
            this.btnPrescription = new Button();
            this.btnClose = new Button();
            this.lblStatus = new Label();
            this.headerBar.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
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
            this.header.Size = new Size(400, 30);
            this.header.Text = "Manage Orders";
            //
            // ordersLabel
            //
            this.ordersLabel.AutoSize = false;
            this.ordersLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.ordersLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.ordersLabel.Location = new Point(22, 70);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new Size(300, 20);
            this.ordersLabel.Text = "All orders";
            //
            // ordersGrid
            //
            this.ordersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGrid.BackgroundColor = Color.White;
            this.ordersGrid.Location = new Point(20, 94);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new Size(920, 240);
            this.ordersGrid.SelectionChanged += new System.EventHandler(this.OrdersGrid_SelectionChanged);
            //
            // itemsLabel
            //
            this.itemsLabel.AutoSize = false;
            this.itemsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.itemsLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.itemsLabel.Location = new Point(22, 344);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new Size(400, 20);
            this.itemsLabel.Text = "Items in selected order";
            //
            // itemsGrid
            //
            this.itemsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.itemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.BackgroundColor = Color.White;
            this.itemsGrid.Location = new Point(20, 368);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.Size = new Size(920, 152);
            //
            // actionPanel
            //
            this.actionPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.actionPanel.BackColor = Color.White;
            this.actionPanel.Controls.Add(this.lblSet);
            this.actionPanel.Controls.Add(this.cmbStatus);
            this.actionPanel.Controls.Add(this.btnUpdate);
            this.actionPanel.Controls.Add(this.btnPrescription);
            this.actionPanel.Controls.Add(this.lblStatus);
            this.actionPanel.Controls.Add(this.btnClose);
            this.actionPanel.Location = new Point(20, 532);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new Size(920, 64);
            //
            // lblSet
            //
            this.lblSet.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblSet.Location = new Point(16, 22);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new Size(70, 22);
            this.lblSet.Text = "Set status";
            this.lblSet.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cmbStatus
            //
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = FlatStyle.Flat;
            this.cmbStatus.Location = new Point(90, 19);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new Size(180, 26);
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
            this.btnUpdate.Location = new Point(286, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(150, 32);
            this.btnUpdate.Text = "Update status";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            //
            // btnPrescription
            //
            this.btnPrescription.BackColor = Color.White;
            this.btnPrescription.Cursor = Cursors.Hand;
            this.btnPrescription.Enabled = false;
            this.btnPrescription.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnPrescription.FlatAppearance.BorderSize = 1;
            this.btnPrescription.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnPrescription.FlatStyle = FlatStyle.Flat;
            this.btnPrescription.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnPrescription.Location = new Point(448, 17);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new Size(160, 32);
            this.btnPrescription.Text = "View prescription";
            this.btnPrescription.UseVisualStyleBackColor = false;
            this.btnPrescription.Click += new System.EventHandler(this.BtnPrescription_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = false;
            this.lblStatus.ForeColor = Color.FromArgb(46, 158, 107);
            this.lblStatus.Location = new Point(624, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(180, 22);
            this.lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnClose
            //
            this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClose.BackColor = Color.White;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClose.Location = new Point(804, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // ManageOrdersForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(960, 620);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(880, 600);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.actionPanel);
            this.Name = "ManageOrdersForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Manage Orders";
            this.headerBar.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
