using System;
using System.Collections.Generic;

namespace cw10.Models
{
    public partial class Players
    {
        public int IdPlayer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
