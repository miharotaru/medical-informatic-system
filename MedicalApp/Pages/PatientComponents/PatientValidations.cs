using MedicalSystems.Data;

namespace MedicalSystem.Pages.PatientComponents
{
    public class PatientValidations
    {
        public static bool ValidatePatient(string name, string email)
        {
            if (name.Length > 0 && email.Length > 0 && StartsWithUpperCase(name) && EmailContainsAtCharacter(email) && EmailEndsWithDotCom(email) && email!=null && name!=null)
            {
                return true;
            }
            else return false;
        }

        private static bool EmailContainsAtCharacter (string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else return false;
        }

        private static bool EmailEndsWithDotCom(string email)
        {
            if (email.EndsWith(".com"))
            {
                return true;
            }
            else return false;
        }

        private static bool StartsWithUpperCase(string name)
        {
            if (char.IsUpper(name[0]))
            {
                return true;
            }
            else return false;
        }
    }

}
