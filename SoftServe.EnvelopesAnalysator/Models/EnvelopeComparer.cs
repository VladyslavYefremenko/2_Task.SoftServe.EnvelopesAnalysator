using System.Collections.Generic;

namespace SoftServe.EnvelopesAnalysator
{
    public class EnvelopeComparer : IComparer<Envelope>
    {
        public int Compare(Envelope envelopeLeft, Envelope envelopeRight)
        {
            int result = -1;

            if ((envelopeLeft.HighEnvelope > envelopeRight.HighEnvelope && envelopeLeft.WeightEnvelope > envelopeRight.WeightEnvelope)
                || (envelopeLeft.HighEnvelope > envelopeRight.WeightEnvelope && envelopeLeft.WeightEnvelope > envelopeRight.HighEnvelope))
            {
                result = 1;
            }
            if ((envelopeRight.HighEnvelope > envelopeLeft.HighEnvelope && envelopeRight.WeightEnvelope > envelopeLeft.WeightEnvelope)
                || (envelopeRight.HighEnvelope > envelopeLeft.WeightEnvelope && envelopeRight.WeightEnvelope > envelopeLeft.HighEnvelope))
            {
                result = 1;
            }

            return result;
        }
    }
}
