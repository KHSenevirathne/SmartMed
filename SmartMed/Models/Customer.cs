using System;

namespace SmartMed.Models
{
    public class Customer : Person
    {
        public DateTime DateRegistered { get; set; }

        public Customer()
        {
            DateRegistered = DateTime.Now;
        }

        public override string Role
        {
            get { return "Customer"; }
        }
    }
}
