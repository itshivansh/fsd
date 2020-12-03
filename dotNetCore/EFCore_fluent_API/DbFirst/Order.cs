using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
