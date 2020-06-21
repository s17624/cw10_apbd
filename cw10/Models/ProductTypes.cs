using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class ProductTypes
    {
        public ProductTypes()
        {
            InverseIdParentTypeNavigation = new HashSet<ProductTypes>();
            Products = new HashSet<Products>();
            Sizes = new HashSet<Sizes>();
        }

        public int IdType { get; set; }
        public string Name { get; set; }
        public int? IdParentType { get; set; }

        public virtual ProductTypes IdParentTypeNavigation { get; set; }
        public virtual ICollection<ProductTypes> InverseIdParentTypeNavigation { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Sizes> Sizes { get; set; }
    }
}
