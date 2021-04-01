using System;
using System.Collections.Generic;
using System.Text;

using Printers;


namespace SoftServe.AnalysisOfEnvelope
{
    class UserEnter
    {
        public static void ReadUserEnter(out string highFirstEnvelope, out string weightFirstEnvelope, out string highSecondEnvelope, out string weightSecondEnvelope)
        {
            string message1 = "Enter high of first envelope:";
            string message2 = "Enter weight of first envelope: ";
            string message3 = "Enter high of second envelope:";
            string message4 = "Enter weight of second envelope:";

            Console.Clear();

            Printer<String>.PrintMessage(message1);
            highFirstEnvelope = Console.ReadLine();

            Console.Clear();

            Printer<String>.PrintMessage(message2);
            weightFirstEnvelope = Console.ReadLine();

            Console.Clear();

            Printer<String>.PrintMessage(message3);
            highSecondEnvelope = Console.ReadLine();

            Console.Clear();

            Printer<String>.PrintMessage(message4);
            weightSecondEnvelope = Console.ReadLine();
        }
    }
}
