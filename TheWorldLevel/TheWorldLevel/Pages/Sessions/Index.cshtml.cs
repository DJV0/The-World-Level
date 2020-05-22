using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheWorldLevel.Data;
using TheWorldLevel.Models;

namespace TheWorldLevel.Pages.Sessions
{
    public class IndexModel : PageModel
    {
        private readonly TheWorldLevel.Data.ApplicationDbContext _context;

        public IndexModel(TheWorldLevel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; }

        public async Task OnGetAsync()
        {
            Session = await _context.Session
                .Include(s => s.Room)
                .Include(s => s.User).ToListAsync();
        }
    }
}
