using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalSystems.Data
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
