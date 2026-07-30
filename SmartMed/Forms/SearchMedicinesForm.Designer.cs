using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    partial class SearchMedicinesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerBar;
        private Label header;
        private Panel filterPanel;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chkExact;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblMin;
        private TextBox txtMin;
        private Label lblMax;
        private TextBox txtMax;
        private Label lblSort;
        private ComboBox cmbSort;
        private Button btnSearch;
        private Button btnReset;
        private DataGridView grid;
        private Label lblCount;
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
            this.filterPanel = new Panel();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.chkExact = new CheckBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblMin = new Label();
            this.txtMin = new TextBox();
            this.lblMax = new Label();
            this.txtMax = new TextBox();
            this.lblSort = new Label();
            this.cmbSort = new ComboBox();
            this.btnSearch = new Button();
            this.btnReset = new Button();
            this.grid = new DataGridView();
            this.lblCount = new Label();
            this.btnClose = new Button();
            this.headerBar.SuspendLayout();
            this.filterPanel.SuspendLayout();
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
            this.header.Size = new Size(400, 30);
            this.header.Text = "Search Medicines";
            //
            // filterPanel
            //
            this.filterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.filterPanel.BackColor = Color.White;
            this.filterPanel.Controls.Add(this.lblName);
            this.filterPanel.Controls.Add(this.txtName);
            this.filterPanel.Controls.Add(this.chkExact);
            this.filterPanel.Controls.Add(this.lblCategory);
            this.filterPanel.Controls.Add(this.cmbCategory);
            this.filterPanel.Controls.Add(this.lblMin);
            this.filterPanel.Controls.Add(this.txtMin);
            this.filterPanel.Controls.Add(this.lblMax);
            this.filterPanel.Controls.Add(this.txtMax);
            this.filterPanel.Controls.Add(this.lblSort);
            this.filterPanel.Controls.Add(this.cmbSort);
            this.filterPanel.Controls.Add(this.btnSearch);
            this.filterPanel.Controls.Add(this.btnReset);
            this.filterPanel.Location = new Point(20, 72);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new Size(900, 92);
            //
            // lblName
            //
            this.lblName.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblName.Location = new Point(16, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(180, 16);
            this.lblName.Text = "Name contains";
            //
            // txtName
            //
            this.txtName.BorderStyle = BorderStyle.FixedSingle;
            this.txtName.Location = new Point(16, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(180, 26);
            //
            // chkExact
            //
            this.chkExact.Cursor = Cursors.Hand;
            this.chkExact.ForeColor = Color.FromArgb(51, 65, 92);
            this.chkExact.Location = new Point(16, 62);
            this.chkExact.Name = "chkExact";
            this.chkExact.Size = new Size(180, 20);
            this.chkExact.Text = "Exact match";
            this.chkExact.UseVisualStyleBackColor = true;
            this.chkExact.CheckedChanged += new System.EventHandler(this.ChkExact_CheckedChanged);
            //
            // lblCategory
            //
            this.lblCategory.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblCategory.Location = new Point(210, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(150, 16);
            this.lblCategory.Text = "Category";
            //
            // cmbCategory
            //
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = FlatStyle.Flat;
            this.cmbCategory.Location = new Point(210, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(150, 26);
            //
            // lblMin
            //
            this.lblMin.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblMin.Location = new Point(374, 12);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new Size(80, 16);
            this.lblMin.Text = "Min price";
            //
            // txtMin
            //
            this.txtMin.BorderStyle = BorderStyle.FixedSingle;
            this.txtMin.Location = new Point(374, 32);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new Size(80, 26);
            //
            // lblMax
            //
            this.lblMax.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblMax.Location = new Point(468, 12);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new Size(80, 16);
            this.lblMax.Text = "Max price";
            //
            // txtMax
            //
            this.txtMax.BorderStyle = BorderStyle.FixedSingle;
            this.txtMax.Location = new Point(468, 32);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new Size(80, 26);
            //
            // lblSort
            //
            this.lblSort.ForeColor = Color.FromArgb(51, 65, 92);
            this.lblSort.Location = new Point(562, 12);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new Size(150, 16);
            this.lblSort.Text = "Sort by";
            //
            // cmbSort
            //
            this.cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = FlatStyle.Flat;
            this.cmbSort.Items.AddRange(new object[] {
                "Name (A-Z)",
                "Price (low-high)",
                "Price (high-low)"});
            this.cmbSort.Location = new Point(562, 32);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new Size(150, 26);
            //
            // btnSearch
            //
            this.btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnSearch.BackColor = Color.FromArgb(64, 84, 178);
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 70, 156);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(728, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(156, 32);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            //
            // btnReset
            //
            this.btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnReset.BackColor = Color.White;
            this.btnReset.Cursor = Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = Color.FromArgb(201, 208, 222);
            this.btnReset.FlatAppearance.BorderSize = 1;
            this.btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 241, 247);
            this.btnReset.FlatStyle = FlatStyle.Flat;
            this.btnReset.ForeColor = Color.FromArgb(51, 65, 92);
            this.btnReset.Location = new Point(728, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(156, 30);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            //
            // grid
            //
            this.grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = Color.White;
            this.grid.Location = new Point(20, 176);
            this.grid.Name = "grid";
            this.grid.Size = new Size(900, 372);
            //
            // lblCount
            //
            this.lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblCount.AutoSize = false;
            this.lblCount.ForeColor = Color.FromArgb(138, 147, 166);
            this.lblCount.Location = new Point(20, 558);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new Size(500, 22);
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
            this.btnClose.Location = new Point(820, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 32);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            //
            // SearchMedicinesForm
            //
            this.BackColor = Color.FromArgb(244, 246, 251);
            this.ClientSize = new Size(940, 600);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(860, 560);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClose);
            this.Name = "SearchMedicinesForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "SmartMed Pharmacy - Search Medicines";
            this.headerBar.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
