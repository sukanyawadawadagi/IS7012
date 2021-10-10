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
    public class StatisticModel : PageModel
    {
        private readonly FinalProject.Data.FinalProjectContext _context;

        public StatisticModel(FinalProject.Data.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Bookappointment> Bookappointment { get;set; }
        public int TotalCars { get; set; }
        public int TotalParts { get; set; }
        public int TotalManuf { get; set; }


        public async Task OnGetAsync()
        {
            TotalCars = await _context.Sellyourcar.CountAsync();
            TotalParts = await _context.Findcarpart.CountAsync();
            TotalManuf = await _context.Manufacturer.CountAsync();

        }
    }
}
