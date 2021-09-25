using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Company
    {
        [Range(0, 100000000)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Optional Start Date")]
        public DateTime OptionalStartDate { get; set; }

        [DisplayName("Min Salary")]
        [Range(0.00, 100000000.00)]
        public decimal MinSalary { get; set; }

        [DisplayName("Max Salary")]
        [Range(0.00, 100000000.00)]
        public decimal MaxSalary { get; set; }

        [DisplayName("Company Share Value")]
        [Range(0.00, 100000000.00)]
        public decimal CompanyShareValue { get; set; }

        [DisplayName("Position Name")]
        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }

        [DisplayName("Insurance Coverage?")]
        public bool InsuranceCoverage { get; set; }

        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Industry")]
       
        public int IndustryId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle Jobtitle { get; set; }

        [DisplayName("Job Title")]
     
        public int JobtitleId { get; set; }


    }
}
