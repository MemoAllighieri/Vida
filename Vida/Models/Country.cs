using System;
using System.Collections.Generic;

namespace Vida.Models
{
    public partial class Country
    {
        public Country()
        {
            Users = new HashSet<User>();
        }

        public int CountryId { get; set; }
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
