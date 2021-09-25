using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWadawash.Models
{
    public class Industry
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 100000000)]
        public int ID { get; set; }

        [DisplayName("Market Share")]
        [Range(0, 100000000)]
        public int MarketShare { get; set; }

        public List<Candidate> Candidates { get; set; }

        public List<Company> Companies { get; set; }

    }
}
