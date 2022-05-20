using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
