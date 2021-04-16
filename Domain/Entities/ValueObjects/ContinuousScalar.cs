using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class ContinuousScalar
    {
        public float Value { get; set; }
        public float LowerBound { get; set; }
        public float UpperBound { get; set; }
    }
}
