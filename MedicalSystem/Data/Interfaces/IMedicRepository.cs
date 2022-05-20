using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalSystems.Data
{
    public interface IMedicRepository
    {
        public List<Medic> GetMedics();
        public bool CreateMedic(Medic objEmployee);

        public Medic GetMedicById(int id);

        public bool UpdateMedic(Medic objEmployee);

        public bool DeleteMedic(Medic objEmployee);
    }
}
