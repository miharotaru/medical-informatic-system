using System.ComponentModel.DataAnnotations;

namespace MedicalSystems.Data
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }
        public string DrugNames { get; set; } = " ";
        public string IsCompensated { get; set; } = "No";
    }
}
