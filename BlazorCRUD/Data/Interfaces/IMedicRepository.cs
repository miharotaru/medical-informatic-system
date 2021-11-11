using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public interface IMedicRepository
    {
        public List<Medic> GetEmployee();
        public string Create(Medic objEmployee);

        public Medic GetEmployeeById(int id);

        public string UpdateEmployee(Medic objEmployee);

        public string DeleteEmpInfo(Medic objEmployee);
    }
}
