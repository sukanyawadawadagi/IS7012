using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatWadawash.Models;

namespace RecruitCatWadawash.Data
{
    public class RecruitCatWadawashContext : DbContext
    {
        public RecruitCatWadawashContext (DbContextOptions<RecruitCatWadawashContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatWadawash.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatWadawash.Models.Company> Company { get; set; }

        public DbSet<RecruitCatWadawash.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatWadawash.Models.JobTitle> JobTitle { get; set; }
    }
}
