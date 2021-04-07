using System;

namespace SoftServe.EnvelopesAnalysatorView
{
    class UserInput
    {
        public static void ReadUserEnter(out string highFirstEnvelope, out string weightFirstEnvelope, out string highSecondEnvelope, out string weightSecondEnvelope)
        {
            string message1 = "Enter high of first envelope:";
            string message2 = "Enter weight of first envelope: ";
            string message3 = "Enter high of second envelope:";
            string message4 = "Enter weight of second envelope:";

            Console.Clear();

            Printer printer = new Printer();

            printer.Message(message1);
            highFirstEnvelope = Console.ReadLine();

            Console.Clear();

            printer.Message(message2);
            weightFirstEnvelope = Console.ReadLine();

            Console.Clear();

            printer.Message(message3);
            highSecondEnvelope = Console.ReadLine();

            Console.Clear();

            printer.Message(message4);
            weightSecondEnvelope = Console.ReadLine();
        }
    }
}
