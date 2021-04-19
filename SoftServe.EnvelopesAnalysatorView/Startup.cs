using System;
using System.Collections.Generic;

using SoftServe.EnvelopesAnalysator;


namespace SoftServe.EnvelopesAnalysatorView
{
    class Startup
    {
        public static void Start()
        {
            bool restartApp = false;

            IValidators validators = new Validators();
            IPrinter printer = new Printer();
            IComparer<Envelope> envelopeComparer = new EnvelopeComparer();

            do
            {
                Envelope envelope1;
                Envelope envelope2;

                string highFirstEnvelope;
                string weightFirstEnvelope;
                string highSecondEnvelope;
                string weightSecondEnvelope;

                UserInput.ReadUserEnter(printer, out highFirstEnvelope, out weightFirstEnvelope, out highSecondEnvelope, out weightSecondEnvelope);

                if (validators.ValidatSides(highFirstEnvelope, weightFirstEnvelope, highSecondEnvelope, weightSecondEnvelope))
                {
                    bool comparerResult = envelopeComparer.Compare(envelope1 = new Envelope(double.Parse(highFirstEnvelope), double.Parse(weightFirstEnvelope)),
                        envelope2 = new Envelope(double.Parse(highSecondEnvelope), double.Parse(weightSecondEnvelope))) == 1;

                    printer.PrintResult(comparerResult);
                }
                else
                {
                    printer.Instraction(DefaultSettings.InstractionPath);
                    Console.ReadKey();
                    return;
                }

                restartApp = RestartAnalysator.Restart(printer);
            } while (restartApp);
        }
    }
}
