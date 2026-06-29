using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class PlaceOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Label catalogueLabel;
        private DataGridView medicinesGrid;
        private Label qtyLabel;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private Button btnClose;
        private Panel cartPanel;
        private Label cartLabel;
        private DataGridView cartGrid;
        private Button btnRemove;
        private Button btnClearCart;
        private Label lblTotal;
        private Button btnUpload;
        private Label lblPrescription;
        private Button btnPlace;

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
            this.catalogueLabel = new Label();
            this.medicinesGrid = new DataGridView();
            this.qtyLabel = new Label();
            this.numQuantity = new NumericUpDown();
            this.btnAdd = new Button();
            this.btnClose = new Button();
            this.cartPanel = new Panel();
            this.cartLabel = new Label();
            this.cartGrid = new DataGridView();
            this.btnRemove = new Button();
            this.btnClearCart = new Button();
            this.lblTotal = new Label();
            this.btnUpload = new Button();
            this.lblPrescription = new Label();
            this.btnPlace = new Button();
            this.headerBar.SuspendLayout();
            this.cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.SuspendLayout();
            //
            // headerBar
            //
            this.headerBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.headerBar.BackColor = Color.FromArgb(31, 42, 68);
            this.headerBar.Controls.Add(this.header);
            this.headerBar.Location = new Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new Size(980, 56);
            //
            // header
            //
            this.header.AutoSize = false;
            this.header.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.header.ForeColor = Color.White;
            this.header.Location = new Point(20, 13);
            this.header.Name = "header";
            this.header.Size = new Size(400, 30);
            this.header.Text = "Place an Order";
            //
            // catalogueLabel
            //
            this.catalogueLabel.AutoSize = false;
            this.catalogueLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.catalogueLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.catalogueLabel.Location = new Point(22, 70);
            this.catalogueLabel.Name = "catalogueLabel";
            this.catalogueLabel.Size = new Size(300, 20);
            this.catalogueLabel.Text = "Available medicines";
            //
            // medicinesGrid
            //
            this.medicinesGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.medicinesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.medicinesGrid.BackgroundColor = Color.White;
            this.medicinesGrid.Location = new Point(20, 94);
            this.medicinesGrid.Name = "medicinesGrid";
            this.medicinesGrid.Size = new Size(560, 430);
            //
            // qtyLabel
            //
            this.qtyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.qtyLabel.ForeColor = Color.FromArgb(51, 65, 92);
            this.qtyLabel.Location = new Point(20, 536);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new Size(60, 26);
            this.qtyLabel.Text = "Quantity";
            this.qtyLabel.TextAlign = ContentAlignment.MiddleLeft;
            //
            // numQuantity
            //
            this.numQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.numQuantity.BorderStyle = BorderStyle.FixedSingle;
            this.numQuantity.Location = new Point(86, 534);
            this.numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new Size(80, 26);
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAdd
            //
            this.btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnAdd.BackColor = Color.FromArgb(64, 84, 178);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(178, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(150, 32);
            this.btnAdd.Text = "Add to cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            //
            // btnClose
            //
            this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnClose.BackColor = Color.White;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClose.Location = new Point(440, 532);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(120, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // cartPanel
            //
            this.cartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.cartPanel.BackColor = Color.White;
            this.cartPanel.Controls.Add(this.cartLabel);
            this.cartPanel.Controls.Add(this.cartGrid);
            this.cartPanel.Controls.Add(this.btnRemove);
            this.cartPanel.Controls.Add(this.btnClearCart);
            this.cartPanel.Controls.Add(this.lblTotal);
            this.cartPanel.Controls.Add(this.btnUpload);
            this.cartPanel.Controls.Add(this.lblPrescription);
            this.cartPanel.Controls.Add(this.btnPlace);
            this.cartPanel.Location = new Point(600, 94);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new Size(360, 504);
            //
            // cartLabel
            //
            this.cartLabel.AutoSize = false;
            this.cartLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.cartLabel.ForeColor = Color.FromArgb(31, 42, 68);
            this.cartLabel.Location = new Point(16, 12);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new Size(300, 22);
            this.cartLabel.Text = "Your cart";
            //
            // cartGrid
            //
            this.cartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGrid.BackgroundColor = Color.White;
            this.cartGrid.Location = new Point(16, 40);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.Size = new Size(328, 248);
            //
            // btnRemove
            //
            this.btnRemove.BackColor = Color.White;
            this.btnRemove.Cursor = Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnRemove.FlatAppearance.BorderSize = 1;
            this.btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnRemove.Location = new Point(16, 298);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(158, 32);
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            //
            // btnClearCart
            //
            this.btnClearCart.BackColor = Color.White;
            this.btnClearCart.Cursor = Cursors.Hand;
            this.btnClearCart.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnClearCart.FlatAppearance.BorderSize = 1;
            this.btnClearCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnClearCart.FlatStyle = FlatStyle.Flat;
            this.btnClearCart.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnClearCart.Location = new Point(186, 298);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new Size(158, 32);
            this.btnClearCart.Text = "Clear cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.BtnClearCart_Click);
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTotal.ForeColor = Color.FromArgb(64, 84, 178);
            this.lblTotal.Location = new Point(16, 344);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new Size(328, 32);
            this.lblTotal.Text = "Total:";
            //
            // btnUpload
            //
            this.btnUpload.BackColor = Color.White;
            this.btnUpload.Cursor = Cursors.Hand;
            this.btnUpload.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnUpload.FlatAppearance.BorderSize = 1;
            this.btnUpload.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnUpload.FlatStyle = FlatStyle.Flat;
            this.btnUpload.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnUpload.Location = new Point(16, 384);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new Size(328, 32);
            this.btnUpload.Text = "Upload prescription";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            //
            // lblPrescription
            //
            this.lblPrescription.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblPrescription.Location = new Point(16, 420);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new Size(328, 32);
            this.lblPrescription.Text = "No prescription uploaded.";
            //
            // btnPlace
            //
            this.btnPlace.BackColor = Color.FromArgb(46, 158, 107);
            this.btnPlace.Cursor = Cursors.Hand;
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 138, 92);
            this.btnPlace.FlatStyle = FlatStyle.Flat;
            this.btnPlace.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnPlace.ForeColor = Color.White;
            this.btnPlace.Location = new Point(16, 456);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new Size(328, 44);
            this.btnPlace.Text = "Place Order";
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.BtnPlace_Click);
            //
            // PlaceOrderForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(980, 620);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(900, 600);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.catalogueLabel);
            this.Controls.Add(this.medicinesGrid);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cartPanel);
            this.Name = "PlaceOrderForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Place Order";
            this.headerBar.ResumeLayout(false);
            this.cartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicinesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
