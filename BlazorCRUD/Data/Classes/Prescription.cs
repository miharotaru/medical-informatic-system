using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public string DrugName { get; set; }
        public bool IsCompensated { get; set; }
    }
}
