using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label subtitle;
        private Button btnLogout;
        private Label lblActions;
        private Button btnSearch;
        private Button btnPlaceOrder;
        private Button btnTrackOrders;
        private Button btnProfile;
        private Label notifTitle;
        private FlowLayoutPanel noticesPanel;

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
            this.btnLogout = new Button();
            this.lblActions = new Label();
            this.btnSearch = new Button();
            this.btnPlaceOrder = new Button();
            this.btnTrackOrders = new Button();
            this.btnProfile = new Button();
            this.notifTitle = new Label();
            this.noticesPanel = new FlowLayoutPanel();
            this.headerBar.SuspendLayout();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.header);
            this.headerBar.Controls.Add(this.subtitle);
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
            this.header.Size = new Size(600, 28);
            this.header.Text = "Welcome";
            //
            // subtitle
            //
            this.subtitle.AutoSize = false;
            this.subtitle.Font = new Font("Segoe UI", 9F);
            this.subtitle.ForeColor = Color.FromArgb(160, 170, 195);
            this.subtitle.Location = new Point(26, 40);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new Size(500, 18);
            this.subtitle.Text = "Customer portal";
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
            // lblActions
            //
            this.lblActions.AutoSize = false;
            this.lblActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblActions.ForeColor = Color.FromArgb(31, 42, 68);
            this.lblActions.Location = new Point(24, 86);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new Size(400, 24);
            this.lblActions.Text = "What would you like to do?";
            //
            // btnSearch
            //
            this.btnSearch.BackColor = Color.FromArgb(64, 84, 178);
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(24, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(210, 58);
            this.btnSearch.Text = "Search Medicines";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            //
            // btnPlaceOrder
            //
            this.btnPlaceOrder.BackColor = Color.FromArgb(46, 158, 107);
            this.btnPlaceOrder.Cursor = Cursors.Hand;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 138, 92);
            this.btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            this.btnPlaceOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = Color.White;
            this.btnPlaceOrder.Location = new Point(244, 118);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new Size(210, 58);
            this.btnPlaceOrder.Text = "Place an Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            //
            // btnTrackOrders
            //
            this.btnTrackOrders.BackColor = Color.FromArgb(64, 84, 178);
            this.btnTrackOrders.Cursor = Cursors.Hand;
            this.btnTrackOrders.FlatAppearance.BorderSize = 0;
            this.btnTrackOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnTrackOrders.FlatStyle = FlatStyle.Flat;
            this.btnTrackOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnTrackOrders.ForeColor = Color.White;
            this.btnTrackOrders.Location = new Point(464, 118);
            this.btnTrackOrders.Name = "btnTrackOrders";
            this.btnTrackOrders.Size = new Size(210, 58);
            this.btnTrackOrders.Text = "Track My Orders";
            this.btnTrackOrders.UseVisualStyleBackColor = false;
            this.btnTrackOrders.Click += new System.EventHandler(this.BtnTrackOrders_Click);
            //
            // btnProfile
            //
            this.btnProfile.BackColor = Color.FromArgb(64, 84, 178);
            this.btnProfile.Cursor = Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnProfile.FlatStyle = FlatStyle.Flat;
            this.btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnProfile.ForeColor = Color.White;
            this.btnProfile.Location = new Point(684, 118);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new Size(214, 58);
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            //
            // notifTitle
            //
            this.notifTitle.AutoSize = false;
            this.notifTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.notifTitle.ForeColor = Color.FromArgb(31, 42, 68);
            this.notifTitle.Location = new Point(24, 196);
            this.notifTitle.Name = "notifTitle";
            this.notifTitle.Size = new Size(400, 24);
            this.notifTitle.Text = "Promotions & offers";
            //
            // noticesPanel
            //
            this.noticesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.noticesPanel.AutoScroll = true;
            this.noticesPanel.BackColor = Color.White;
            this.noticesPanel.BorderStyle = BorderStyle.FixedSingle;
            this.noticesPanel.FlowDirection = FlowDirection.TopDown;
            this.noticesPanel.Location = new Point(24, 228);
            this.noticesPanel.Name = "noticesPanel";
            this.noticesPanel.Padding = new Padding(6);
            this.noticesPanel.Size = new Size(874, 368);
            this.noticesPanel.WrapContents = false;
            //
            // CustomerDashboardForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(920, 620);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(880, 600);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnTrackOrders);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.notifTitle);
            this.Controls.Add(this.noticesPanel);
            this.Name = "CustomerDashboardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Customer Dashboard";
            this.headerBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
