using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ValueObjects
{
    class Angle
    {
        private double radians;

        public double Radians { get => radians; set { radians = value; } }

        public double ClampedRadians => Radians % 2 * Math.PI;
    }
}
