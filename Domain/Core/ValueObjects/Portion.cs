using Domain.Core.Exceptions;

namespace Domain.Core.ValueObjects
{
    public class Portion
    {
        public double Value { get; }

        public Portion(double value)
        {
            if(value < 0 - double.Epsilon || value > 1 + double.Epsilon)
            {
                throw new ValueOutOfBoundsException();
            }
            Value = value;
        }
    }
}
