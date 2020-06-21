using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class DeliveryMethods
    {
        public DeliveryMethods()
        {
            Orders = new HashSet<Orders>();
        }

        public int IdMethod { get; set; }
        public string MetName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
