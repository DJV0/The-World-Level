using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Game
    {
        public Game()
        {
            Gamecategory = new HashSet<Gamecategory>();
            Image = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? PlayersNumber { get; set; }
        public string ImgUrl { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Gamecategory> Gamecategory { get; set; }
        public virtual ICollection<Image> Image { get; set; }
    }
}
