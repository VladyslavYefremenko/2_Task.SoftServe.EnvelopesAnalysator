namespace SoftServe.EnvelopesAnalysator
{
    public class Validators : IValidators
    {
        public bool ValidatSides(string arg1, string arg2, string arg3, string arg4)
        {
            bool isValid = false;

            if ((IsNumDouble(arg1) && IsNumDouble(arg2) && IsNumDouble(arg3) && IsNumDouble(arg4))
                && (double.Parse(arg1) > DefaultSettings.MIN_SIZE
                && double.Parse(arg2) > DefaultSettings.MIN_SIZE
                && double.Parse(arg3) > DefaultSettings.MIN_SIZE
                && double.Parse(arg4) > DefaultSettings.MIN_SIZE))
            {
                isValid = true;
            }

            return isValid;
        }

        public bool IsNumDouble(string arg)
        {
            bool isDouble = true;

            if (!double.TryParse(arg, out _))
            {
                isDouble = false;
            }
            return isDouble;
        }
    }
}
