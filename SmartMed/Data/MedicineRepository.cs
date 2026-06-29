using SmartMed.Models;

namespace SmartMed.Data
{
    public class MedicineRepository : JsonRepository<Medicine>
    {
        public MedicineRepository() : base("medicines.json") { }

        protected override int GetId(Medicine item)
        {
            return item.Id;
        }

        protected override void SetId(Medicine item, int id)
        {
            item.Id = id;
        }
    }
}
