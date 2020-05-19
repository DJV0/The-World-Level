using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Category
    {
        public Category()
        {
            Gamecategory = new HashSet<Gamecategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gamecategory> Gamecategory { get; set; }
    }
}
