using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Promos
    {
        public Promos()
        {
            PromoDetails = new HashSet<PromoDetails>();
        }

        public int IdPromo { get; set; }
        public string Name { get; set; }
        public DateTime PromoStart { get; set; }
        public DateTime PromoEnd { get; set; }

        public virtual ICollection<PromoDetails> PromoDetails { get; set; }
    }
}
