using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.AnalysisOfEnvelope
{
    class RestartAnalysator
    {
        public static bool Restart()
        {
            bool restartApp = false;
            string message = "Continue? (Enter y/yes - to continue.)";
            string userAnswer = string.Empty;

            Console.Clear();

            Printer<string>.PrintMessage(message);
            userAnswer = Console.ReadLine();
            userAnswer = userAnswer.ToLower();

            if (userAnswer == "y" || userAnswer == "yes")
            {
                restartApp = true;
            }

            return restartApp;
        }
    }
}
