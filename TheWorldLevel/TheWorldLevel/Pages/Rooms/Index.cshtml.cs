using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheWorldLevel.Data;
using TheWorldLevel.Data.interfaces;
using TheWorldLevel.Data.Repository;
using TheWorldLevel.Models;

namespace TheWorldLevel.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        //private readonly TheWorldLevel.Data.ApplicationDbContext _context;
        private readonly IRooms _rooms;

        public IndexModel(IRooms rooms)
        {
            //_context = context;
            _rooms = rooms;
        }

        public IList<Room> Room { get;set; }

        public void OnGet()
        {
            Room = _rooms.Rooms.ToList();
        }
    }
}
