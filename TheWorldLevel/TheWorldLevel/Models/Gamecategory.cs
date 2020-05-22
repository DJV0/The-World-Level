using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Gamecategory
    {
        public int GameId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Game Game { get; set; }
    }
}
