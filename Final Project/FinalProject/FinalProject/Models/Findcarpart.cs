using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Findcarpart
    {
        [Range(0, 100000000)]
        public int Id { get; set; }
        [DisplayName("Part Name")]
        [Required]
        [StringLength(100)]
        public string PartName { get; set; }
        [DisplayName("Part Value")]
        [Range(0.00, 100000000.00)]
        public decimal PartValue { get; set; }
        [DisplayName("Is It Obsolete?")]
        public bool IsItObsolete { get; set; }
        [DisplayName("Part Model No")]
        [Required]
        public string PartModelNo { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [DisplayName("Manufacturer Name")]
        public int ManufacturerId { get; set; }
    }
}
