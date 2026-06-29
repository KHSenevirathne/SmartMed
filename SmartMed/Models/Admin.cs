namespace SmartMed.Models
{
    public class Admin : Person
    {
        public override string Role
        {
            get { return "Admin"; }
        }
    }
}
