using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string Medic { get; set; }
        public string Patient { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
