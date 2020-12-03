using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        public int? RetirementYears { get; set; }
        public string PassportNo { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
