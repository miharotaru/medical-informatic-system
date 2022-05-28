namespace MedicalSystem.Pages.MedicComponents
{
    public class MedicValidations
    {
        public static bool ValidateMedic(string name, float ratePerHour)
        {
            if (name.Length > 0 && ratePerHour > 0 && ratePerHour < 1000 && char.IsUpper(name[0]))
            {
                return true;
            }
            else return false;
        }
    }
}


