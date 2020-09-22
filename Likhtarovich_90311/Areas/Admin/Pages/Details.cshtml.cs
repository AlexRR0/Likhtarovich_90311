using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Likhtarovich_90311.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(Likhtarovich_90311.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
