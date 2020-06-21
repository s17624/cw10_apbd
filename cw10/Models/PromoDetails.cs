using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class PromoDetails
    {
        public int IdPromo { get; set; }
        public int IdProduct { get; set; }
        public decimal Discount { get; set; }

        public virtual Products IdProductNavigation { get; set; }
        public virtual Promos IdPromoNavigation { get; set; }
    }
}
