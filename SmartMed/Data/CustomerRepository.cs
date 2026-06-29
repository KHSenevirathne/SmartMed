using SmartMed.Models;

namespace SmartMed.Data
{
    public class CustomerRepository : JsonRepository<Customer>
    {
        public CustomerRepository() : base("customers.json") { }

        protected override int GetId(Customer item)
        {
            return item.Id;
        }

        protected override void SetId(Customer item, int id)
        {
            item.Id = id;
        }
    }
}
