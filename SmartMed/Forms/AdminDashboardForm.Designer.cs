using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label welcome;
        private Button btnLogout;
        private Panel panelSales;
        private Panel accentSales;
        private Label lblSalesCaption;
        private Label cardSales;
        private Panel panelStock;
        private Panel accentStock;
        private Label lblStockCaption;
        private Label cardStock;
        private Panel panelOrders;
        private Panel accentOrders;
        private Label lblOrdersCaption;
        private Label cardOrders;
        private Label lblActions;
        private Button btnManageMedicines;
        private Button btnManageCustomers;
        private Button btnManageOrders;
        private Button btnReports;
        private Label notifTitle;
        private FlowLayoutPanel notificationsPanel;

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
            this.welcome = new Label();
            this.btnLogout = new Button();
            this.panelSales = new Panel();
            this.accentSales = new Panel();
            this.lblSalesCaption = new Label();
            this.cardSales = new Label();
            this.panelStock = new Panel();
            this.accentStock = new Panel();
            this.lblStockCaption = new Label();
            this.cardStock = new Label();
            this.panelOrders = new Panel();
            this.accentOrders = new Panel();
            this.lblOrdersCaption = new Label();
            this.cardOrders = new Label();
            this.lblActions = new Label();
            this.btnManageMedicines = new Button();
            this.btnManageCustomers = new Button();
            this.btnManageOrders = new Button();
            this.btnReports = new Button();
            this.notifTitle = new Label();
            this.notificationsPanel = new FlowLayoutPanel();
            this.headerBar.SuspendLayout();
            this.panelSales.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.header);
            this.headerBar.Controls.Add(this.welcome);
            this.headerBar.Controls.Add(this.btnLogout);
            this.headerBar.Location = new Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new Size(920, 66);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(24, 10);
            this.header.Name = "header";
            this.header.Size = new Size(500, 28);
            this.header.Text = "Admin Dashboard";
            //
            // welcome
            //
            this.welcome.AutoSize = false;
            this.welcome.Font = new Font("Segoe UI", 9F);
            this.welcome.ForeColor = Color.FromArgb(160, 170, 195);
            this.welcome.Location = new Point(26, 40);
            this.welcome.Name = "welcome";
            this.welcome.Size = new Size(500, 18);
            //
            // btnLogout
            //
            this.btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLogout.BackColor = Color.FromArgb(31, 42, 68);
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = Color.FromArgb(96, 108, 138);
            this.btnLogout.FlatAppearance.BorderSize = 1;
            this.btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 61, 92);
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 9.5F);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(806, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(92, 32);
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            //
            // panelSales
            //
            this.panelSales.BackColor = Color.White;
            this.panelSales.Controls.Add(this.accentSales);
            this.panelSales.Controls.Add(this.lblSalesCaption);
            this.panelSales.Controls.Add(this.cardSales);
            this.panelSales.Location = new Point(24, 88);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new Size(282, 112);
            //
            // accentSales
            //
            this.accentSales.BackColor = Color.FromArgb(64, 84, 178);
            this.accentSales.Dock = DockStyle.Top;
            this.accentSales.Location = new Point(0, 0);
            this.accentSales.Name = "accentSales";
            this.accentSales.Size = new Size(282, 5);
            //
            // lblSalesCaption
            //
            this.lblSalesCaption.AutoSize = false;
            this.lblSalesCaption.Font = new Font("Segoe UI", 10F);
            this.lblSalesCaption.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblSalesCaption.Location = new Point(18, 22);
            this.lblSalesCaption.Name = "lblSalesCaption";
            this.lblSalesCaption.Size = new Size(246, 22);
            this.lblSalesCaption.Text = "Total Sales";
            //
            // cardSales
            //
            this.cardSales.AutoSize = false;
            this.cardSales.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.cardSales.ForeColor = Color.FromArgb(64, 84, 178);
            this.cardSales.Location = new Point(15, 50);
            this.cardSales.Name = "cardSales";
            this.cardSales.Size = new Size(252, 46);
            this.cardSales.Text = "...";
            //
            // panelStock
            //
            this.panelStock.BackColor = Color.White;
            this.panelStock.Controls.Add(this.accentStock);
            this.panelStock.Controls.Add(this.lblStockCaption);
            this.panelStock.Controls.Add(this.cardStock);
            this.panelStock.Location = new Point(320, 88);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new Size(282, 112);
            //
            // accentStock
            //
            this.accentStock.BackColor = Color.FromArgb(46, 158, 107);
            this.accentStock.Dock = DockStyle.Top;
            this.accentStock.Location = new Point(0, 0);
            this.accentStock.Name = "accentStock";
            this.accentStock.Size = new Size(282, 5);
            //
            // lblStockCaption
            //
            this.lblStockCaption.AutoSize = false;
            this.lblStockCaption.Font = new Font("Segoe UI", 10F);
            this.lblStockCaption.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblStockCaption.Location = new Point(18, 22);
            this.lblStockCaption.Name = "lblStockCaption";
            this.lblStockCaption.Size = new Size(246, 22);
            this.lblStockCaption.Text = "Medicines in Stock";
            //
            // cardStock
            //
            this.cardStock.AutoSize = false;
            this.cardStock.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.cardStock.ForeColor = Color.FromArgb(46, 158, 107);
            this.cardStock.Location = new Point(15, 50);
            this.cardStock.Name = "cardStock";
            this.cardStock.Size = new Size(252, 46);
            this.cardStock.Text = "...";
            //
            // panelOrders
            //
            this.panelOrders.BackColor = Color.White;
            this.panelOrders.Controls.Add(this.accentOrders);
            this.panelOrders.Controls.Add(this.lblOrdersCaption);
            this.panelOrders.Controls.Add(this.cardOrders);
            this.panelOrders.Location = new Point(616, 88);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new Size(282, 112);
            //
            // accentOrders
            //
            this.accentOrders.BackColor = Color.FromArgb(232, 169, 59);
            this.accentOrders.Dock = DockStyle.Top;
            this.accentOrders.Location = new Point(0, 0);
            this.accentOrders.Name = "accentOrders";
            this.accentOrders.Size = new Size(282, 5);
            //
            // lblOrdersCaption
            //
            this.lblOrdersCaption.AutoSize = false;
            this.lblOrdersCaption.Font = new Font("Segoe UI", 10F);
            this.lblOrdersCaption.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblOrdersCaption.Location = new Point(18, 22);
            this.lblOrdersCaption.Name = "lblOrdersCaption";
            this.lblOrdersCaption.Size = new Size(246, 22);
            this.lblOrdersCaption.Text = "Active Orders";
            //
            // cardOrders
            //
            this.cardOrders.AutoSize = false;
            this.cardOrders.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.cardOrders.ForeColor = Color.FromArgb(232, 169, 59);
            this.cardOrders.Location = new Point(15, 50);
            this.cardOrders.Name = "cardOrders";
            this.cardOrders.Size = new Size(252, 46);
            this.cardOrders.Text = "...";
            //
            // lblActions
            //
            this.lblActions.AutoSize = false;
            this.lblActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblActions.ForeColor = Color.FromArgb(31, 42, 68);
            this.lblActions.Location = new Point(24, 218);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new Size(300, 24);
            this.lblActions.Text = "Quick actions";
            //
            // btnManageMedicines
            //
            this.btnManageMedicines.BackColor = Color.FromArgb(64, 84, 178);
            this.btnManageMedicines.Cursor = Cursors.Hand;
            this.btnManageMedicines.FlatAppearance.BorderSize = 0;
            this.btnManageMedicines.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnManageMedicines.FlatStyle = FlatStyle.Flat;
            this.btnManageMedicines.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnManageMedicines.ForeColor = Color.White;
            this.btnManageMedicines.Location = new Point(24, 250);
            this.btnManageMedicines.Name = "btnManageMedicines";
            this.btnManageMedicines.Size = new Size(210, 54);
            this.btnManageMedicines.Text = "Manage Medicines";
            this.btnManageMedicines.UseVisualStyleBackColor = false;
            this.btnManageMedicines.Click += new System.EventHandler(this.BtnManageMedicines_Click);
            //
            // btnManageCustomers
            //
            this.btnManageCustomers.BackColor = Color.FromArgb(64, 84, 178);
            this.btnManageCustomers.Cursor = Cursors.Hand;
            this.btnManageCustomers.FlatAppearance.BorderSize = 0;
            this.btnManageCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnManageCustomers.FlatStyle = FlatStyle.Flat;
            this.btnManageCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnManageCustomers.ForeColor = Color.White;
            this.btnManageCustomers.Location = new Point(244, 250);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new Size(210, 54);
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.BtnManageCustomers_Click);
            //
            // btnManageOrders
            //
            this.btnManageOrders.BackColor = Color.FromArgb(64, 84, 178);
            this.btnManageOrders.Cursor = Cursors.Hand;
            this.btnManageOrders.FlatAppearance.BorderSize = 0;
            this.btnManageOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnManageOrders.FlatStyle = FlatStyle.Flat;
            this.btnManageOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnManageOrders.ForeColor = Color.White;
            this.btnManageOrders.Location = new Point(464, 250);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new Size(210, 54);
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.BtnManageOrders_Click);
            //
            // btnReports
            //
            this.btnReports.BackColor = Color.FromArgb(64, 84, 178);
            this.btnReports.Cursor = Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnReports.FlatStyle = FlatStyle.Flat;
            this.btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnReports.ForeColor = Color.White;
            this.btnReports.Location = new Point(684, 250);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new Size(214, 54);
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            //
            // notifTitle
            //
            this.notifTitle.AutoSize = false;
            this.notifTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.notifTitle.ForeColor = Color.FromArgb(31, 42, 68);
            this.notifTitle.Location = new Point(24, 324);
            this.notifTitle.Name = "notifTitle";
            this.notifTitle.Size = new Size(300, 24);
            this.notifTitle.Text = "Notifications";
            //
            // notificationsPanel
            //
            this.notificationsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.notificationsPanel.AutoScroll = true;
            this.notificationsPanel.BackColor = Color.White;
            this.notificationsPanel.BorderStyle = BorderStyle.FixedSingle;
            this.notificationsPanel.FlowDirection = FlowDirection.TopDown;
            this.notificationsPanel.Location = new Point(24, 356);
            this.notificationsPanel.Name = "notificationsPanel";
            this.notificationsPanel.Padding = new Padding(6);
            this.notificationsPanel.Size = new Size(874, 240);
            this.notificationsPanel.WrapContents = false;
            //
            // AdminDashboardForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(920, 620);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(880, 600);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.panelSales);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.btnManageMedicines);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.notifTitle);
            this.Controls.Add(this.notificationsPanel);
            this.Name = "AdminDashboardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Admin Dashboard";
            this.headerBar.ResumeLayout(false);
            this.panelSales.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
