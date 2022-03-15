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
        public int Medic { get; set; }
        public int Patient { get; set; }
        public DateTime Date { get; set; }
    }
}
