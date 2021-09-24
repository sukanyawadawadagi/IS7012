using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public DateTime OptionalStartDate { get; set; }

        public decimal MinSalary { get; set; }

        public decimal MaxSalary { get; set; }

        public decimal CompanyShareValue { get; set; }

        public string PositionName { get; set; }

        public bool InsuranceCoverage { get; set; }

        public List<Candidate> Candidates { get; set; }

        public Industry Industry { get; set; }

        public int IndustryId { get; set; }

        public JobTitle Jobtitle { get; set; }

        public int JobtitleId { get; set; }


    }
}
