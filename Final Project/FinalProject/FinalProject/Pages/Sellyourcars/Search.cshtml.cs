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
    public class SearchModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public SearchModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Sellyourcar> Sellyourcar { get;set; }

        public bool SearchCompleted { get; set; }
        public string Query { get; set;}
        public int TotalCars { get; set; }
        public int TotalParts { get; set; }
        public int TotalManuf { get; set; }

        

        public async Task OnGetAsync(string query)
        {   
            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Sellyourcar = await _context.Sellyourcar.Where(x => x.ModelNo.Equals(query)).ToListAsync();

            }
            else
            {
                SearchCompleted = false;
                Sellyourcar = new List<Sellyourcar>();

            }
            //Sellyourcar = await _context.Sellyourcar.ToListAsync();
        }
    }
}
