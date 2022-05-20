using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalSystems.Data
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _db;

        public AppointmentRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Appointment> GetAppointments()
        {
            var appointments = _db.Appointments.ToList();
            return appointments;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return true;
        }

        public Appointment GetAppointmentById(int id)
        {
            return _db.Appointments.FirstOrDefault(s => s.AppointmentId == id);
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            _db.Appointments.Update(appointment);
            _db.SaveChanges();
            return true;
        }

        public bool DeleteAppointment(Appointment appointment)
        {
            _db.Remove(appointment);
            _db.SaveChanges();
            return true;
        }
    }
}
