using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        public string JobDescription { get; set; }

        public decimal MiniSalary { get; set; }

        public decimal MaxSalary { get; set; }

        public string Title { get; set; }

        public List<Candidate> Candidates { get; set; }

    }
}
