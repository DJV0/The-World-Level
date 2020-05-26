using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int? RoomId { get; set; }
        public int? GameId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Room Room { get; set; }
    }
}
