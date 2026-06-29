using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class TrackOrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label ordersLabel;
        private DataGridView ordersGrid;
        private Label itemsLabel;
        private DataGridView itemsGrid;
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
            this.ordersLabel = new Label();
            this.ordersGrid = new DataGridView();
            this.itemsLabel = new Label();
            this.itemsGrid = new DataGridView();
            this.btnClose = new Button();
            this.headerBar.SuspendLayout();
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
            this.headerBar.Size = new Size(820, 56);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(20, 13);
            this.header.Name = "header";
            this.header.Size = new Size(400, 30);
            this.header.Text = "Track My Orders";
            //
            // ordersLabel
            //
            this.ordersLabel.AutoSize = false;
            this.ordersLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.ordersLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.ordersLabel.Location = new Point(22, 70);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new Size(300, 20);
            this.ordersLabel.Text = "My orders";
            //
            // ordersGrid
            //
            this.ordersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGrid.BackgroundColor = Color.White;
            this.ordersGrid.Location = new Point(20, 94);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new Size(780, 244);
            this.ordersGrid.SelectionChanged += new System.EventHandler(this.OrdersGrid_SelectionChanged);
            //
            // itemsLabel
            //
            this.itemsLabel.AutoSize = false;
            this.itemsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.itemsLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.itemsLabel.Location = new Point(22, 348);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new Size(400, 20);
            this.itemsLabel.Text = "Items in selected order";
            //
            // itemsGrid
            //
            this.itemsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.itemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGrid.BackgroundColor = Color.White;
            this.itemsGrid.Location = new Point(20, 372);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.Size = new Size(780, 168);
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
            this.btnClose.Location = new Point(700, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // TrackOrdersForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(820, 600);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(760, 560);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.itemsGrid);
            this.Controls.Add(this.btnClose);
            this.Name = "TrackOrdersForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Track My Orders";
            this.headerBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
