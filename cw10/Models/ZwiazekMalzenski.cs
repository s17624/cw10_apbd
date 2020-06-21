using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class ZwiazekMalzenski
    {
        public int IdZwiazku { get; set; }
        public int? IdMiejscowosci { get; set; }
        public DateTime DataZawarciaZwiazku { get; set; }
        public DateTime? DataWygasnieciaZwiazku { get; set; }
        public string PowodWygasnieciaZwiazku { get; set; }
        public string Maz { get; set; }
        public string Zona { get; set; }

        public virtual Miejscowosc IdMiejscowosciNavigation { get; set; }
        public virtual Osoba MazNavigation { get; set; }
        public virtual Osoba ZonaNavigation { get; set; }
    }
}
