using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Service
    {
        public Service()
        {
            Sessionservice = new HashSet<Sessionservice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Sessionservice> Sessionservice { get; set; }
    }
}
