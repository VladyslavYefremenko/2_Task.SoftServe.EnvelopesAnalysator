namespace SoftServe.EnvelopesAnalysator
{
    public class Validators : IValidators
    {
        private double num1;
        private double num2;
        private double num3;
        private double num4;

        public bool ValidatSides(string arg1, string arg2, string arg3, string arg4)
        {
            bool isValid = false;

            if ((IsNumDouble(arg1, out num1) && IsNumDouble(arg2, out num2) && IsNumDouble(arg3, out num3) && IsNumDouble(arg4, out num4))
                && (num1 > DefaultSettings.MinSize
                && num2 > DefaultSettings.MinSize
                && num3 > DefaultSettings.MinSize
                && num4 > DefaultSettings.MinSize))
            {
                isValid = true;
            }

            return isValid;
        }

        public bool IsNumDouble(string arg, out double num)
        {
            bool isDouble = true;
            num = 0.0;

            if (!double.TryParse(arg, out num))
            {
                isDouble = false;
            }

            return isDouble;
        }
    }
}
