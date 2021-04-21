using Domain.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public sealed class SignedPortion : Portion
    {
        public override double Value { get; }

        public SignedPortion(double value)
        {
            if (value < 0 - double.Epsilon || value > 1 + double.Epsilon)
            {
                throw new ValueOutOfBoundsException();
            }
            Value = value;
        }

        public static SignedPortion Max = new SignedPortion(1);

        public static SignedPortion Min = new SignedPortion(-1);

        public SignedPortion Duplicate()
        {
            return new SignedPortion(Value);
        }
    }
}
