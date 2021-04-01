using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.AnalysisOfEnvelope
{
    class EnvelopeComparer
    {
        public static bool CompareEnveloprs(Envelope envelopeLeft, Envelope envelopeRight)
        {
            bool isInserted = false;

            if ((envelopeLeft.HighEnvelope > envelopeRight.HighEnvelope && envelopeLeft.WeightEnvelope > envelopeRight.WeightEnvelope) 
                || (envelopeLeft.HighEnvelope > envelopeRight.WeightEnvelope && envelopeLeft.WeightEnvelope > envelopeRight.HighEnvelope))
            {
                isInserted = true;
            }
            if ((envelopeRight.HighEnvelope > envelopeLeft.HighEnvelope && envelopeRight.WeightEnvelope > envelopeLeft.WeightEnvelope)
                || (envelopeRight.HighEnvelope > envelopeLeft.WeightEnvelope && envelopeRight.WeightEnvelope > envelopeLeft.HighEnvelope))
            {
                isInserted = true;
            }

            return isInserted;
        }
    }
}
