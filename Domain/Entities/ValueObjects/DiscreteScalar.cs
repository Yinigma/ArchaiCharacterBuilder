using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class DiscreteScalar
    {
        public int Value { get; set; }
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
    }
}
