using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Products
    {
        public Products()
        {
            Offer = new HashSet<Offer>();
            PromoDetails = new HashSet<PromoDetails>();
        }

        public int IdProduct { get; set; }
        public int IdBrand { get; set; }
        public int IdProdType { get; set; }
        public string ProdName { get; set; }
        public decimal BasePrice { get; set; }

        public virtual Brands IdBrandNavigation { get; set; }
        public virtual ProductTypes IdProdTypeNavigation { get; set; }
        public virtual ICollection<Offer> Offer { get; set; }
        public virtual ICollection<PromoDetails> PromoDetails { get; set; }
    }
}
