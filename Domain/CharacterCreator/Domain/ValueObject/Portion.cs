using Domain.Core.Exceptions;

namespace Domain.Core.ValueObjects
{
    public abstract class Portion
    {
        public virtual double Value { get; }

        public bool Equals(UnsignedPortion portion)
        {
            return portion.Value == Value;
        }
    }
}
