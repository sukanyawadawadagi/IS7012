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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public IndexModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Findcarpart> Findcarpart { get;set; }

        public async Task OnGetAsync()
        {
            Findcarpart = await _context.Findcarpart
                .Include(f => f.Manufacturer).ToListAsync();
        }
    }
}
