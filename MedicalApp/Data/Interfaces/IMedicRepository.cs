using System.Collections.Generic;

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
