namespace MedicalSystem.Pages.PrescriptionComponents
{
    public class PrescriptionValidations
    {
        public static bool ValidateDrugs(string druglist)
        {
            if (druglist.Length > 0 && druglist != null)
            {
                return true;
            }
            else return false;
        }
    }
}
