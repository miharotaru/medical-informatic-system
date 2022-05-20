using System.ComponentModel.DataAnnotations;

namespace MedicalSystems.Data
{
    public class Medic
    {
        [Key]
        public int MedicId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public float RatePerHour { get; set; } 
    }
}
