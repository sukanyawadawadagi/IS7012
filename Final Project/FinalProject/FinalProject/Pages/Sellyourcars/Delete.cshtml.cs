using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Sellyourcars
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public DeleteModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sellyourcar Sellyourcar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sellyourcar = await _context.Sellyourcar.FirstOrDefaultAsync(m => m.Id == id);

            if (Sellyourcar == null)
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

            Sellyourcar = await _context.Sellyourcar.FindAsync(id);

            if (Sellyourcar != null)
            {
                _context.Sellyourcar.Remove(Sellyourcar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
