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

        public static readonly Color White = new Color(UnsignedPortion.Max, UnsignedPortion.Max, UnsignedPortion.Max); 

        public static Color createFromRGB(UnsignedPortion red, UnsignedPortion green, UnsignedPortion blue) 
        {
            return new Color(red, green, blue);
        }

        private Color(UnsignedPortion red, UnsignedPortion green, UnsignedPortion blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static Color createTransparent()
        {
            return new Color(UnsignedPortion.Min, UnsignedPortion.Min, UnsignedPortion.Min);
        }

        public bool Equals(Color c)
        {
            return Red.Equals(c.Red) && Green.Equals(c.Green) && Blue.Equals(c.Blue); 
        }
    }
}
