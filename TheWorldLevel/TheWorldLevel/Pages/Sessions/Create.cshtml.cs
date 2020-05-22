using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheWorldLevel.Data;
using TheWorldLevel.Models;

namespace TheWorldLevel.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        private readonly TheWorldLevel.Data.ApplicationDbContext _context;

        public CreateModel(TheWorldLevel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RoomId"] = new SelectList(_context.Room, "Id", "Name");
        ViewData["UserId"] = new SelectList(_context.Aspnetusers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Session.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
