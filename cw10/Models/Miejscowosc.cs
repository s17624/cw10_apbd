using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Miejscowosc
    {
        public Miejscowosc()
        {
            Osoba = new HashSet<Osoba>();
            ZwiazekMalzenski = new HashSet<ZwiazekMalzenski>();
        }

        public int IdMiejscowosci { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Osoba> Osoba { get; set; }
        public virtual ICollection<ZwiazekMalzenski> ZwiazekMalzenski { get; set; }
    }
}
