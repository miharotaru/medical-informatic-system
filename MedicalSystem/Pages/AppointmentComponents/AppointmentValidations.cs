using MedicalSystems.Data;
using System.Linq;

namespace MedicalSystem.Pages.AppointmentComponents
{
    public class AppointmentValidations
    {

        public static bool IsValidAppointment(Appointment appointment)
        {
            if (appointment.Medic == null || appointment.Medic.Length <= 0)
            {
                return false;
            }
            if (appointment.Patient == null || appointment.Patient.Length <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
