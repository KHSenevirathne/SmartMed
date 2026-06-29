using SmartMed.Models;

namespace SmartMed.Data
{
    public class OrderRepository : JsonRepository<Order>
    {
        public OrderRepository() : base("orders.json") { }

        protected override int GetId(Order item)
        {
            return item.Id;
        }

        protected override void SetId(Order item, int id)
        {
            item.Id = id;
        }
    }
}
