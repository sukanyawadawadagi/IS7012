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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatWadawash.Data.RecruitCatWadawashContext _context;

        public IndexModel(RecruitCatWadawash.Data.RecruitCatWadawashContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
