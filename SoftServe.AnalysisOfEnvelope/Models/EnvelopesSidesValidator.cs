using System;
using System.Collections.Generic;
using System.Text;

using Validators;

namespace SoftServe.AnalysisOfEnvelope
{
    class EnvelopesSidesValidator
    {
        public static bool ValidatSides(string arg1, string arg2, string arg3, string arg4)
        {
            bool isValid = false;

            const double MIN_SIZE = 0.1;

            if ((Validator.IsNumDouble(arg1) && Validator.IsNumDouble(arg2) && Validator.IsNumDouble(arg3) && Validator.IsNumDouble(arg4))
                && (double.Parse(arg1) > MIN_SIZE && double.Parse(arg2) > MIN_SIZE && double.Parse(arg3) > MIN_SIZE && double.Parse(arg4) > MIN_SIZE))
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
