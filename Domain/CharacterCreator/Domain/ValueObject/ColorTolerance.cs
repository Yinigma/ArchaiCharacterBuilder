using Archai.CharacterCreator.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public sealed class ColorTolerance
    {
        public Angle HueTolerance { get; }
        public Portion SaturationTolerance { get; }
        public Portion ValueTolerance { get; }

        public ColorTolerance(Angle hueTolerance, Portion satTolerance, Portion valTolerance )
        {
            HueTolerance = hueTolerance;
            SaturationTolerance = satTolerance;
            ValueTolerance = valTolerance;
        }

        public bool Equals(ColorTolerance other)
        {
            return HueTolerance.Equals(other.HueTolerance) && SaturationTolerance.Equals(other.SaturationTolerance) && ValueTolerance.Equals(other.ValueTolerance);
        }
    }
}
