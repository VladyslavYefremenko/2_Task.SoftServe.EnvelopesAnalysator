using SoftServe.EnvelopesAnalysator;
using System;

namespace SoftServe.EnvelopesAnalysatorView
{
    class Startup
    {
        public static void Start()
        {
            bool restartApp = false;

            Envelope envelope1;
            Envelope envelope2;

            string highFirstEnvelope;
            string weightFirstEnvelope;
            string highSecondEnvelope;
            string weightSecondEnvelope;

            Validators validators = new Validators();
            Printer printer = new Printer();
            EnvelopeComparer envelopeComparer = new EnvelopeComparer();

            do
            {
                UserInput.ReadUserEnter(out highFirstEnvelope, out weightFirstEnvelope, out highSecondEnvelope, out weightSecondEnvelope);

                if (validators.ValidatSides(highFirstEnvelope, weightFirstEnvelope, highSecondEnvelope, weightSecondEnvelope))
                {
                    bool comparerResult = false;

                    if (envelopeComparer.Compare(envelope1 = new Envelope(double.Parse(highFirstEnvelope), double.Parse(weightFirstEnvelope)),
                        envelope2 = new Envelope(double.Parse(highSecondEnvelope), double.Parse(weightSecondEnvelope))) == 1)
                    {
                        comparerResult = true;
                    }

                    printer.PrintResult(comparerResult);
                }
                else
                {
                    printer.Instraction(DefaultSettings.instractionPath);
                    Console.ReadKey();
                    return;
                }

                restartApp = RestartAnalysator.Restart();
            } while (restartApp);
        }
    }
}
