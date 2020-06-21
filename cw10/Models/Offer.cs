using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Offer
    {
        public Offer()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int IdProdOffer { get; set; }
        public int IdProduct { get; set; }
        public int IdSize { get; set; }
        public int OnStock { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual Sizes IdSizeNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
