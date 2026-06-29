namespace SmartMed.Models
{
    public class OrderItem
    {
        public int MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal LineTotal
        {
            get { return Quantity * UnitPrice; }
        }
    }
}
