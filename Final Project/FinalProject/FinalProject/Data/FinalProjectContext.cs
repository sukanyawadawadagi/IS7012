using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Bookappointment> Bookappointment { get; set; }

        public DbSet<FinalProject.Models.Findcarpart> Findcarpart { get; set; }

        public DbSet<FinalProject.Models.Manufacturer> Manufacturer { get; set; }

        public DbSet<FinalProject.Models.Sellyourcar> Sellyourcar { get; set; }
    }
}
