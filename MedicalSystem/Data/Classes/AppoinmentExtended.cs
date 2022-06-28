using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalSystems.Data
{
    public class AppointmentExtended
    {
        public string Medic { get; set; }
        public string Patient { get; set; }
        public string Prescription { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
