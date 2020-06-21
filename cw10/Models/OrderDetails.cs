using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class OrderDetails
    {
        public int IdOrder { get; set; }
        public int IdProdOffer { get; set; }
        public int InOrder { get; set; }

        public virtual Orders IdOrderNavigation { get; set; }
        public virtual Offer IdProdOfferNavigation { get; set; }
    }
}
