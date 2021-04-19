using System;

namespace SoftServe.EnvelopesAnalysatorView
{
    class RestartAnalysator
    {
        public static bool Restart(IPrinter printer)
        {
            bool restartApp = false;
            string message = "Continue? (Enter y/yes - to continue.)";
            string[] userAnswers = { "y", "yes" };
            string userInput = string.Empty;

            Console.Clear();

            printer.Message(message);
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if (userInput == userAnswers[0] || userInput == userAnswers[1])
            {
                restartApp = true;
            }

            return restartApp;
        }
    }
}
