using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Room
    {
        public Room()
        {
            Image = new HashSet<Image>();
            Session = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte PlayersNumber { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<Session> Session { get; set; }
    }
}
