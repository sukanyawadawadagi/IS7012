using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatWadawash.Data;
using RecruitCatWadawash.Models;

namespace RecruitCatWadawash.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatWadawash.Data.RecruitCatWadawashContext _context;

        public DetailsModel(RecruitCatWadawash.Data.RecruitCatWadawashContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.ID == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
