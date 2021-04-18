using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public sealed class Color
    {
        public Portion Red { get; }
        public Portion Green { get; }
        public Portion Blue { get; }
        public bool Solid { get; }

        public static Color createFromRGB(double red, double green, double blue) 
        {
            return new Color(red, green, blue, true);
        }

        private Color(double red, double green, double blue, bool solid)
        {
            Red = new Portion(red);
            Green = new Portion(green);
            Blue = new Portion(blue);
            Solid = solid;
        }

        public static Color createTransparent()
        {
            return new Color(0, 0, 0, false);
        }
    }
}
