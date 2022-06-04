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

        public bool CreateAppointment(Appointment appointment, string patientMail)
        {
            var validationResult = ValidateAppointment(appointment.Medic, appointment.Patient);

            if(validationResult == true)
            {
                _db.Appointments.Add(appointment);
                _db.SaveChanges();
                
                SendMailConfirmation(appointment, patientMail);
                return true;
            }

            return false;
        }

        public bool ValidateAppointment(string MedicName, string PatientName)
        {
            var doesMedicExist = _db.Medics.Where(m => m.Name == MedicName).FirstOrDefault();
            var doesPatientExist = _db.Patients.Where(p => p.Name == PatientName).FirstOrDefault();

            if(doesMedicExist != null && doesPatientExist !=null)
            {
                return true;
            }
            else return false;
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

        public bool ValidatePrescription(int PrescriptionId)
        {
            if (_db.Prescriptions.Where(x => x.PrescriptionId == PrescriptionId).FirstOrDefault() != null)
            {
                return true;
            }
            else return false;
        }
        

        public string GetPatientMailByAppointment(Appointment appointment)
        {
            var result = _db.Patients.Where(p => p.Name == appointment.Patient).FirstOrDefault();

            return result.Email;
        }
    }
}
