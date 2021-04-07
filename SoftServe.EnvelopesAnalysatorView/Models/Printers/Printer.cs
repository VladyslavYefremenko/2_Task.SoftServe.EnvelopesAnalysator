using System;
using System.IO;

namespace SoftServe.EnvelopesAnalysatorView
{
    class Printer : IPrinter
    {
        public void Instraction(string instractionFilePath)
        {
            StreamReader sr = new StreamReader(instractionFilePath);
            string line = sr.ReadLine();

            Console.Clear();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintResult(bool isInserted)
        {
            Printer printer = new Printer();

            if (isInserted)
            {
                Console.Clear();
                printer.Message(DefaultSettings.postitveResult);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                printer.Message(DefaultSettings.negariteResult);
                Console.ReadKey();
            }
        }
    }
}
