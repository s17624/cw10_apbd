using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Sizes
    {
        public Sizes()
        {
            Offer = new HashSet<Offer>();
        }

        public int IdSizeType { get; set; }
        public int IdType { get; set; }
        public string SizeField1 { get; set; }
        public string SizeField2 { get; set; }

        public virtual ProductTypes IdTypeNavigation { get; set; }
        public virtual ICollection<Offer> Offer { get; set; }
    }
}
