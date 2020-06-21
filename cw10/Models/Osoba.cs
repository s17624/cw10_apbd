using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Osoba
    {
        public Osoba()
        {
            InverseMatkaNavigation = new HashSet<Osoba>();
            InverseOjciecNavigation = new HashSet<Osoba>();
            ZwiazekMalzenskiMazNavigation = new HashSet<ZwiazekMalzenski>();
            ZwiazekMalzenskiZonaNavigation = new HashSet<ZwiazekMalzenski>();
        }

        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public int? MiejsceUrodzenia { get; set; }
        public DateTime? DataZgonu { get; set; }
        public string Matka { get; set; }
        public string Ojciec { get; set; }
        public string Plec { get; set; }

        public virtual Osoba MatkaNavigation { get; set; }
        public virtual Miejscowosc MiejsceUrodzeniaNavigation { get; set; }
        public virtual Osoba OjciecNavigation { get; set; }
        public virtual ICollection<Osoba> InverseMatkaNavigation { get; set; }
        public virtual ICollection<Osoba> InverseOjciecNavigation { get; set; }
        public virtual ICollection<ZwiazekMalzenski> ZwiazekMalzenskiMazNavigation { get; set; }
        public virtual ICollection<ZwiazekMalzenski> ZwiazekMalzenskiZonaNavigation { get; set; }
    }
}
