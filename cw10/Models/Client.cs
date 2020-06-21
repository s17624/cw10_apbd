using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Client
    {
        public Client()
        {
            DeliveryAddreses = new HashSet<DeliveryAddreses>();
            Orders = new HashSet<Orders>();
        }

        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual ICollection<DeliveryAddreses> DeliveryAddreses { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
