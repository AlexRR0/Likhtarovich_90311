﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Likhtarovich_90311.DAL.Data;
using Likhtarovich_90311.DAL.Entities;

namespace Likhtarovich_90311.Areas.Admin.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Likhtarovich_90311.DAL.Data.ApplicationDbContext _context;

        public DeleteModel(Likhtarovich_90311.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Animal Animal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal = await _context.Animals
                .Include(a => a.Group).FirstOrDefaultAsync(m => m.AnimalId == id);

            if (Animal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal = await _context.Animals.FindAsync(id);

            if (Animal != null)
            {
                _context.Animals.Remove(Animal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
