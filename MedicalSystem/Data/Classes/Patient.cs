using System.ComponentModel.DataAnnotations;

namespace MedicalSystems.Data
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; } = " ";
        public string Email { get; set; } = " ";
        public string Symptoms { get; set; } = " ";
        public string ScreeningNotes { get; set; } = " ";
    }
}
