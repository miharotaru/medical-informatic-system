using System.Collections.Generic;

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
