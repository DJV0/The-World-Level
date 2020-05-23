using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Session
    {
        public Session()
        {
            Sessionservice = new HashSet<Sessionservice>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan Duration { get; set; }
        public byte PlayersNumber { get; set; }
        public string UserId { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Aspnetusers User { get; set; }

        public virtual ICollection<Sessionservice> Sessionservice { get; set; }
    }
}
