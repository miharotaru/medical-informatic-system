using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public interface IMedicRepository
    {
        public List<Medic> GetMedics();
        public string CreateMedic(Medic objEmployee);

        public Medic GetMedicById(int id);

        public string UpdateMedic(Medic objEmployee);

        public string DeleteMedic(Medic objEmployee);
    }
}
