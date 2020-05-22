using System;
using System.Collections.Generic;

namespace TheWorldLevel.Models
{
    public partial class Aspnetusers
    {
        public Aspnetusers()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaims>();
            Aspnetuserlogins = new HashSet<Aspnetuserlogins>();
            Aspnetuserroles = new HashSet<Aspnetuserroles>();
            Aspnetusertokens = new HashSet<Aspnetusertokens>();
            Review = new HashSet<Review>();
            Session = new HashSet<Session>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public byte EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public byte PhoneNumberConfirmed { get; set; }
        public byte TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public byte LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual ICollection<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual ICollection<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual ICollection<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<Session> Session { get; set; }
    }
}
