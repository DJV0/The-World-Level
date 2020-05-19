using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public byte Rating { get; set; }
        public string UserId { get; set; }

        public virtual Aspnetusers User { get; set; }
    }
}
