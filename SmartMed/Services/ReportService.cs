using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using SmartMed.Data;
using SmartMed.Models;

namespace SmartMed.Services
{
    public class ReportService
    {
        private readonly MedicineRepository _medicines;
        private readonly OrderRepository _orders;
        private readonly CustomerRepository _customers;

        public ReportService()
        {
            _medicines = new MedicineRepository();
            _orders = new OrderRepository();
            _customers = new CustomerRepository();
        }

        public DataTable GetSalesReport()
        {
            DataTable table = new DataTable("SalesReport");
            table.Columns.Add("Order Id", typeof(int));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Customer", typeof(string));
            table.Columns.Add("Items", typeof(int));
            table.Columns.Add("Total", typeof(decimal));
            table.Columns.Add("Status", typeof(string));

            List<Customer> customers = _customers.GetAll().ToList();

            foreach (Order order in _orders.GetAll().OrderBy(o => o.OrderDate))
            {
                Customer customer = customers.FirstOrDefault(c => c.Id == order.CustomerId);
                string name = customer != null ? customer.FullName : "(unknown)";
                int itemCount = order.Items != null ? order.Items.Sum(i => i.Quantity) : 0;

                table.Rows.Add(
                    order.Id,
                    order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    name,
                    itemCount,
                    order.TotalAmount,
                    order.Status.ToString());
            }
            return table;
        }

        public decimal GetTotalSales()
        {
            return _orders.GetAll().Sum(o => o.TotalAmount);
        }

        public DataTable GetStockReport()
        {
            DataTable table = new DataTable("StockReport");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Discounted", typeof(decimal));
            table.Columns.Add("Expiry", typeof(string));
            table.Columns.Add("Prescription", typeof(string));
            table.Columns.Add("Status", typeof(string));

            foreach (Medicine m in _medicines.GetAll().OrderBy(x => x.Name))
            {
                List<string> flags = new List<string>();
                if (m.IsLowStock())
                {
                    flags.Add("Low stock");
                }
                if (m.IsNearExpiry())
                {
                    flags.Add("Near expiry");
                }
                string status = flags.Count == 0 ? "OK" : string.Join(", ", flags);

                table.Rows.Add(
                    m.Id,
                    m.Name,
                    m.Category,
                    m.Stock,
                    m.Price,
                    m.DiscountedPrice(),
                    m.ExpiryDate.ToString("yyyy-MM-dd"),
                    m.RequiresPrescription ? "Yes" : "No",
                    status);
            }
            return table;
        }

        public DataTable GetCustomerOrderHistory(int customerId)
        {
            DataTable table = new DataTable("CustomerOrderHistory");
            table.Columns.Add("Order Id", typeof(int));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Medicine", typeof(string));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("Unit Price", typeof(decimal));
            table.Columns.Add("Line Total", typeof(decimal));
            table.Columns.Add("Status", typeof(string));

            IEnumerable<Order> orders = _orders.GetAll()
                .Where(o => o.CustomerId == customerId)
                .OrderBy(o => o.OrderDate);

            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.Items)
                {
                    table.Rows.Add(
                        order.Id,
                        order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                        item.MedicineName,
                        item.Quantity,
                        item.UnitPrice,
                        item.LineTotal,
                        order.Status.ToString());
                }
            }
            return table;
        }

        public void ExportToCsv(DataTable table, string filePath)
        {
            if (table == null)
            {
                throw new ArgumentNullException("table");
            }

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> headers = table.Columns
                .Cast<DataColumn>()
                .Select(c => Escape(c.ColumnName));
            sb.AppendLine(string.Join(",", headers));

            foreach (DataRow row in table.Rows)
            {
                IEnumerable<string> fields = row.ItemArray
                    .Select(field => Escape(field == null ? string.Empty : field.ToString()));
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private static string Escape(string value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            bool needsQuotes = value.Contains(",") || value.Contains("\"")
                || value.Contains("\n") || value.Contains("\r");

            if (needsQuotes)
            {
                value = value.Replace("\"", "\"\"");
                return "\"" + value + "\"";
            }
            return value;
        }
    }
}
