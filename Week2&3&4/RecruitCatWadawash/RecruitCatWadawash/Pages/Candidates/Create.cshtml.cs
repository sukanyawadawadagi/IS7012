using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatWadawash.Data;
using RecruitCatWadawash.Models;

namespace RecruitCatWadawash.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatWadawash.Data.RecruitCatWadawashContext _context;

        public CreateModel(RecruitCatWadawash.Data.RecruitCatWadawashContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Name");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "ID", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
