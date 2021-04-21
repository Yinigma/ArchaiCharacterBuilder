using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterWaveDashMovement
    {
        public int WaveLandTime { get; }
        public double WaveLandAdj { get; }
        public double WaveFriction { get; }

        public FighterWaveDashMovement(int waveLandTime, double waveLandAdj, double waveFriction)
        {
            WaveLandTime = waveLandTime;
            WaveLandAdj = waveLandAdj;
            WaveFriction = waveFriction;
        }

        public bool Equals(FighterWaveDashMovement other)
        {
            return other.WaveFriction == WaveFriction && other.WaveLandAdj == WaveLandAdj && other.WaveLandTime == WaveLandTime;
        }

        public FighterWaveDashMovement Duplicate()
        {
            return new FighterWaveDashMovement(WaveLandTime, WaveLandAdj, WaveFriction);
        }
    }
}
