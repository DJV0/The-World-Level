using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Sessionservice
    {
        public int SessionId { get; set; }
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual Session Session { get; set; }
    }
}
