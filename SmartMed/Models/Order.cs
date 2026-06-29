using System;
using System.Collections.Generic;

namespace SmartMed.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; }

        public string PrescriptionFilePath { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status = OrderStatus.Pending;
        }

        public decimal TotalAmount
        {
            get
            {
                decimal total = 0m;
                foreach (OrderItem item in Items)
                {
                    total += item.LineTotal;
                }
                return total;
            }
        }
    }
}
