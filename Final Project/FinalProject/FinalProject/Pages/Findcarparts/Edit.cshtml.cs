using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Findcarparts
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public EditModel(FinalProject.Data.FinalProjectContext context)
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
           ViewData["ManufacturerId"] = new SelectList(_context.Set<Manufacturer>(), "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Findcarpart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FindcarpartExists(Findcarpart.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FindcarpartExists(int id)
        {
            return _context.Findcarpart.Any(e => e.Id == id);
        }
    }
}
