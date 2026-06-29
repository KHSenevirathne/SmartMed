using System;

namespace SmartMed.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Dosage { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Supplier { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool RequiresPrescription { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountedPrice()
        {
            decimal discount = Price * (DiscountPercent / 100m);
            return Math.Round(Price - discount, 2);
        }

        public bool IsNearExpiry(int withinDays = 30)
        {
            return ExpiryDate.Date <= DateTime.Now.Date.AddDays(withinDays);
        }

        public bool IsLowStock(int threshold = 10)
        {
            return Stock <= threshold;
        }
    }
}
