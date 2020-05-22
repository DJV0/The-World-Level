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
    public class DetailsModel : PageModel
    {
        private readonly TheWorldLevel.Data.ApplicationDbContext _context;

        public DetailsModel(TheWorldLevel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Session Session { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Session = await _context.Session
                .Include(s => s.Room)
                .Include(s => s.User).FirstOrDefaultAsync(m => m.Id == id);

            if (Session == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
