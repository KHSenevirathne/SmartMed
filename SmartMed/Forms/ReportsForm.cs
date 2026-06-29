using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService _reports = new ReportService();
        private readonly CustomerRepository _customers = new CustomerRepository();

        private DataTable _current;

        public ReportsForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(grid);
            LoadCustomers();
            ShowSalesReport();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            ShowSalesReport();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            ShowStockReport();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            ShowCustomerHistory();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCustomers()
        {
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.ValueMember = "Id";
            cmbCustomers.DataSource = _customers.GetAll().OrderBy(c => c.FullName).ToList();
        }

        private void ShowSalesReport()
        {
            _current = _reports.GetSalesReport();
            grid.DataSource = _current;
            UiTheme.FormatMoneyColumns(grid, "Total");
            lblTitle.Text = "Sales Report - total revenue " + _reports.GetTotalSales().ToString("C2");
        }

        private void ShowStockReport()
        {
            _current = _reports.GetStockReport();
            grid.DataSource = _current;
            UiTheme.FormatMoneyColumns(grid, "Price", "Discounted");
            lblTitle.Text = "Stock Report";
        }

        private void ShowCustomerHistory()
        {
            Customer customer = cmbCustomers.SelectedItem as Customer;
            if (customer == null)
            {
                MessageBox.Show("Please select a customer first.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _current = _reports.GetCustomerOrderHistory(customer.Id);
            grid.DataSource = _current;
            UiTheme.FormatMoneyColumns(grid, "Unit Price", "Line Total");
            lblTitle.Text = "Order History - " + customer.FullName;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (_current == null || _current.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to export.", "SmartMed Pharmacy",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = _current.TableName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    _reports.ExportToCsv(_current, dialog.FileName);
                    MessageBox.Show("Report exported to:\n" + dialog.FileName, "SmartMed Pharmacy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not export the report:\n" + ex.Message, "SmartMed Pharmacy",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
