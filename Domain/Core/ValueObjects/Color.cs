using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public sealed class Color
    {
        public UnsignedPortion Red { get; }
        public UnsignedPortion Green { get; }
        public UnsignedPortion Blue { get; }
        public bool Solid { get; }

        public static readonly Color White = new Color(UnsignedPortion.Max, UnsignedPortion.Max, UnsignedPortion.Max, true); 

        public static Color createFromRGB(UnsignedPortion red, UnsignedPortion green, UnsignedPortion blue) 
        {
            return new Color(red, green, blue, true);
        }

        private Color(UnsignedPortion red, UnsignedPortion green, UnsignedPortion blue, bool solid)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Solid = solid;
        }

        public static Color createTransparent()
        {
            return new Color(UnsignedPortion.Min, UnsignedPortion.Min, UnsignedPortion.Min, false);
        }

        public Color Duplicate()
        {
            return new Color(Red.Duplicate(), Green.Duplicate(), Blue.Duplicate(), Solid);
        }

        public bool Equals(Color c)
        {
            return Red.Equals(c.Red) && Green.Equals(c.Green) && Blue.Equals(c.Blue) && Solid == c.Solid; 
        }
    }
}
