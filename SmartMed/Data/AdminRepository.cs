using SmartMed.Models;

namespace SmartMed.Data
{
    public class AdminRepository : JsonRepository<Admin>
    {
        public AdminRepository() : base("admins.json") { }

        protected override int GetId(Admin item)
        {
            return item.Id;
        }

        protected override void SetId(Admin item, int id)
        {
            item.Id = id;
        }
    }
}
