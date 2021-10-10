using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Findcarparts
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public DeleteModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Findcarpart Findcarpart { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Findcarpart = await _context.Findcarpart
                .Include(f => f.Manufacturer).FirstOrDefaultAsync(m => m.Id == id);

            if (Findcarpart == null)
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

            Findcarpart = await _context.Findcarpart.FindAsync(id);

            if (Findcarpart != null)
            {
                _context.Findcarpart.Remove(Findcarpart);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
