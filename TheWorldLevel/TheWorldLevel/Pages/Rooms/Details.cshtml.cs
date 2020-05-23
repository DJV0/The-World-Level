﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheWorldLevel.Data;
using TheWorldLevel.Models;

namespace TheWorldLevel.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        private readonly TheWorldLevel.Data.ApplicationDbContext _context;

        public DetailsModel(TheWorldLevel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Room.Include(r => r.Image).FirstOrDefaultAsync(m => m.Id == id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
