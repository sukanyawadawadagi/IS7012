using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Candidate
    {
        [Range(0, 100000000)]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Target Salary")]
        [Range(0.00, 100000000.00)]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Optional Start Date")]
        public DateTime OptionalStartDate { get; set; }

        [DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [DisplayName("Previous Salary")]
        [Range(0.00, 100000000.00)]
        public decimal? PreviousSalary { get; set; }

        [DisplayName("Are you Veteran?")]
        public bool AreYouVeteran { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Application Submit Date")]
        public DateTime ApplicationSubmitDate { get; set; }
  
        [DisplayName("Company")]
        public Company Company { get; set; }

        [DisplayName("Company")]
        
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Job Title")]
      
        public int JobTitleId { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }

        [DisplayName("Industry")]

        public int IndustryId { get; set; }

    }
}
