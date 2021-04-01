using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.AnalysisOfEnvelope
{
    class ResultPrinter : IResultPrinter
    {
        public static void PrintResult(bool isInserted)
        {
            string postitveResult = "One envelope can be placed in another!";
            string negariteResult = "One envelope cannot be placed in another!";

            if (isInserted)
            {
                Console.Clear();
                Printer<String>.PrintMessage(postitveResult);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Printer<String>.PrintMessage(negariteResult);
                Console.ReadKey();
            }
        }
    }
}
