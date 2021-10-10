using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Sellyourcar
    {
            [Range(0, 100000000)]
            public int Id { get; set; }
            [DisplayName("Model No")]
            [Required]

            [StringLength(50)]
            public string ModelNo { get; set; }
            [Required]
            public string? Seller { get; set; }
            [Required]
            [StringLength(50)]
            [DisplayName("Model Name")]
            public string ModelName { get; set; }
            [DisplayName("Year bought")]
            public DateTime YearBought { get; set; }
            [DisplayName("Cost Price")]
            [Required]
            [Range(0.00, 100000000.00)]
            public decimal CostPrice { get; set; }
            [DisplayName("Part Missing?")]
            public bool PartMissing { get; set; }
            [DisplayName("Part Damaged?")]
            public bool PartDamage { get; set; }

        
    }
}
