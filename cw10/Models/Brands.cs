using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Brands
    {
        public Brands()
        {
            Products = new HashSet<Products>();
        }

        public int IdBrand { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
