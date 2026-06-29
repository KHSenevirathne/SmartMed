using System;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Services;
using SmartMed.Utils;

namespace SmartMed.Forms
{
    public partial class TrackOrdersForm : Form
    {
        private readonly OrderRepository _orders = new OrderRepository();

        public TrackOrdersForm()
        {
            InitializeComponent();
            UiTheme.StyleGrid(ordersGrid);
            UiTheme.StyleGrid(itemsGrid);
            LoadOrders();
        }

        private void LoadOrders()
        {
            Customer customer = SessionContext.CurrentCustomer;
            if (customer == null)
            {
                return;
            }

            ordersGrid.DataSource = null;
            ordersGrid.DataSource = _orders.GetAll()
                .Where(o => o.CustomerId == customer.Id)
                .OrderByDescending(o => o.OrderDate)
                .Select(o => new
                {
                    o.Id,
                    Date = o.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    Items = o.Items.Sum(i => i.Quantity),
                    Total = o.TotalAmount,
                    Status = FriendlyStatus(o.Status),
                    Prescription = string.IsNullOrEmpty(o.PrescriptionFilePath) ? "-" : "Attached"
                })
                .ToList();

            UiTheme.FormatMoneyColumns(ordersGrid, "Total");
        }

        private void OrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGrid.CurrentRow == null)
            {
                return;
            }
            object idValue = ordersGrid.CurrentRow.Cells["Id"].Value;
            if (idValue == null)
            {
                return;
            }

            Order order = _orders.GetById(Convert.ToInt32(idValue));
            if (order == null)
            {
                return;
            }

            itemsGrid.DataSource = null;
            itemsGrid.DataSource = order.Items
                .Select(i => new
                {
                    i.MedicineName,
                    Qty = i.Quantity,
                    UnitPrice = i.UnitPrice,
                    LineTotal = i.LineTotal
                })
                .ToList();

            UiTheme.FormatMoneyColumns(itemsGrid, "UnitPrice", "LineTotal");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static string FriendlyStatus(OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.ReadyForPickup:
                    return "Ready for pickup";
                case OrderStatus.Delivered:
                    return "Delivered";
                default:
                    return "Pending";
            }
        }
    }
}
