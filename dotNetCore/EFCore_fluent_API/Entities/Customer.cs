using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Customer
    {
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }
        //[Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public int Contact { get; set; }
        public string email { get; set; }
        public int RetirementYears { get; set; }
        public string PassportNo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
