using Domain.Core.Exceptions;

namespace Domain.Core.ValueObjects
{
    public sealed class UnsignedPortion : Portion
    {
        public override double Value { get; }

        public UnsignedPortion(double value)
        {
            if (value < 0 - double.Epsilon || value > 1 + double.Epsilon)
            {
                throw new ValueOutOfBoundsException();
            }
            Value = value;
        }

        public static UnsignedPortion Max = new UnsignedPortion(1);

        public static UnsignedPortion Min = new UnsignedPortion(0);

        public UnsignedPortion Duplicate()
        {
            return new UnsignedPortion(Value);
        }
    }
}
