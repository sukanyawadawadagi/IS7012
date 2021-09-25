using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class JobTitle
    {
        [Range(0, 100000000)]
        public int Id { get; set; }

        [DisplayName("Job Description")]
        [Required]
        [StringLength(200)]
        public string JobDescription { get; set; }
       

        [DisplayName("Min Salary")]
        [Range(0.00, 100000000.00)]
        public decimal MiniSalary { get; set; }
       

        [DisplayName("Max Salary")]
        [Range(0.00, 100000000.00)]
        public decimal MaxSalary { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public List<Candidate> Candidates { get; set; }

    }
}
