using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Bookappointments
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public DeleteModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bookappointment Bookappointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bookappointment = await _context.Bookappointment.FirstOrDefaultAsync(m => m.Id == id);

            if (Bookappointment == null)
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

            Bookappointment = await _context.Bookappointment.FindAsync(id);

            if (Bookappointment != null)
            {
                _context.Bookappointment.Remove(Bookappointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
