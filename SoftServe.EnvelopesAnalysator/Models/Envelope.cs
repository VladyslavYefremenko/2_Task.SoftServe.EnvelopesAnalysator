namespace SoftServe.EnvelopesAnalysator
{
    public class Envelope : IEnvelope
    {
        private double highEnvelope;
        private double weightEnvelope;

        public double HighEnvelope { get { return highEnvelope; } }
        public double WeightEnvelope { get { return weightEnvelope; } }

        public Envelope(double highEnvelope, double weightEnvelope)
        {
            this.highEnvelope = highEnvelope;
            this.weightEnvelope = weightEnvelope;
        }
    }
}
