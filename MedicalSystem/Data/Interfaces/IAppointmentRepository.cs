using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalSystems.Data
{
    public interface IAppointmentRepository
    {
        public List<Appointment> GetAppointments();
        public bool CreateAppointment(Appointment appointment);

        public Appointment GetAppointmentById(int id);

        public bool UpdateAppointment(Appointment appointment);

        public bool DeleteAppointment(Appointment appointment);
    }
}
