using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.AnalysisOfEnvelope
{
    class Envelope
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
