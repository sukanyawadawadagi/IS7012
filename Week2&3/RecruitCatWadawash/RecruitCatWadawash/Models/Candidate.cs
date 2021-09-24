using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        public DateTime DateOfBirth { get; set; }

        public decimal TargetSalary { get; set; }

        public DateTime OptionalStartDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal? PreviousSalary { get; set; }

        public bool AreYouVeteran { get; set; }

        public DateTime ApplicationSubmitDate { get; set; }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        public JobTitle JobTitle { get; set; }

        public int JobTitleId { get; set; }

        public Industry Industry { get; set; }

        public int IndustryId { get; set; }

    }
}
