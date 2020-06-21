using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class DeliveryAddreses
    {
        public DeliveryAddreses()
        {
            Orders = new HashSet<Orders>();
        }

        public int IdAddress { get; set; }
        public int ClientId { get; set; }
        public string AddresField1 { get; set; }
        public string AddresField2 { get; set; }
        public string AddresField3 { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
