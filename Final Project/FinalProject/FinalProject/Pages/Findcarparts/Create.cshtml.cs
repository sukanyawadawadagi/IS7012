﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Pages.Findcarparts
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
        ViewData["ManufacturerId"] = new SelectList(_context.Set<Manufacturer>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Findcarpart Findcarpart { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Findcarpart.Add(Findcarpart);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
