using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Bookappointment
    {
        [Range(0, 100000000)]
        public int Id { get; set; }
        [DisplayName("Person Name")]
        [Required]
        public string PersonName { get; set; }
        [DisplayName("Person ID")]
        [Required]
        public string PersonId { get; set; }
        [DisplayName("Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
    }
}
