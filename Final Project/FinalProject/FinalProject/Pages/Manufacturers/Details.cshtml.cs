﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Manufacturers
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public DetailsModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        public Manufacturer Manufacturer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacturer = await _context.Manufacturer
                                         .Include(p => p.Findcarparts).FirstOrDefaultAsync(m => m.Id == id);


            if (Manufacturer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
