using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public sealed class Angle
    {
        public double Radians { get; }

        public double Degrees => RadiansToDegrees(Radians);

        public double ClampedRadians => (Radians % (2 * Math.PI) + 2 * Math.PI) % (2 * Math.PI);

        public double ClampedDegrees => (Degrees % 360 + 360) % 360;

        public Angle(double radians)
        {
            Radians = radians;
        }

        public static Angle fromDegrees(double degrees)
        {
            return new Angle(DegreesToRadians(degrees));
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private static double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        public override bool Equals(object other)
        {
            return other is Angle && (other as Angle).Radians == Radians;
        }

        public override int GetHashCode()
        {
            return Radians.GetHashCode();
        }
    }
}
