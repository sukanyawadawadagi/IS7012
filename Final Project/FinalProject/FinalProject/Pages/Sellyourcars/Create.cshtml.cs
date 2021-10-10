using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages.Sellyourcars
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public CreateModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sellyourcar Sellyourcar { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ModelNo_1 = Sellyourcar.ModelNo;
            bool ModelNo_1AlreadyExists = await _context.Sellyourcar.AnyAsync(x => x.ModelNo == ModelNo_1);
            _context.Sellyourcar.Add(Sellyourcar);
            if (ModelNo_1AlreadyExists)
            {
                ModelState.AddModelError("Sellyourcar.ModelNo", "Model No already exists");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
