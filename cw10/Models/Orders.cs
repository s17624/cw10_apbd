using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public int IdAddress { get; set; }
        public int IdMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OrderFinish { get; set; }

        public virtual DeliveryAddreses IdAddressNavigation { get; set; }
        public virtual Client IdClientNavigation { get; set; }
        public virtual DeliveryMethods IdMethodNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
