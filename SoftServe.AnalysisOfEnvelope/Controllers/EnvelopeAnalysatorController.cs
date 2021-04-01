using System;
using System.Collections.Generic;
using System.Text;

using Printers;

namespace SoftServe.AnalysisOfEnvelope
{
    class EnvelopeAnalysatorController
    {

        public static void StartAnalysator()
        {
            string instractionPath = "..\\..\\..\\..\\instraction.txt";

            bool restartApp = false;

            Envelope envelope1;
            Envelope envelope2;

            string highFirstEnvelope;
            string weightFirstEnvelope;
            string highSecondEnvelope;
            string weightSecondEnvelope;

            do
            {
                UserEnter.ReadUserEnter(out highFirstEnvelope, out weightFirstEnvelope, out highSecondEnvelope, out weightSecondEnvelope);

                if (EnvelopesSidesValidator.ValidatSides(highFirstEnvelope, weightFirstEnvelope, highSecondEnvelope, weightSecondEnvelope))
                {
                    ResultPrinter.PrintResult(EnvelopeComparer.CompareEnveloprs(envelope1 = new Envelope(double.Parse(highFirstEnvelope), double.Parse(weightFirstEnvelope)), 
                        envelope2 = new Envelope(double.Parse(highSecondEnvelope), double.Parse(weightSecondEnvelope))));
                }
                else
                {
                    Printer<string>.PrintInstraction(instractionPath);
                }

                restartApp = RestartAnalysator.Restart();
            } while (restartApp);
        }
    }
}
