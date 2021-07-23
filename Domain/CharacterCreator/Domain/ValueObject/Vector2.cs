using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public sealed class Vector2
    {
        public double X { get; }
        public double Y { get; }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator -(Vector2 p) => new Vector2(-p.X, -p.Y);

        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);

        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);
    }
}
