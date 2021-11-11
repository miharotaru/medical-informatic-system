using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Data
{
    public class MedicRepository : IMedicRepository
    {
        private readonly AppDbContext _db;

        public MedicRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Medic> GetEmployee()
        {
            var empList = _db.Medics.ToList();
            return empList;
        }

        public string Create(Medic objEmployee)
        {
            _db.Medics.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public Medic GetEmployeeById(int id)
        {
            Medic employee = _db.Medics.FirstOrDefault(s => s.MedicId == id);
            return employee;
        }

        public string UpdateEmployee(Medic objEmployee)
        {
            _db.Medics.Update(objEmployee);
            _db.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteEmpInfo(Medic objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
