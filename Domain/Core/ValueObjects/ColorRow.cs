using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public sealed class ColorRow
    {
        public Angle HueTolerance { get; }
        public Portion SaturationTolerance { get; }
        public Portion ValueTolerance { get; }

        private List<Color> baseColors;

        public List<Color> BaseColors { get { return new List<Color>(baseColors); } }

        public ColorRow(List<Color> colors, Angle hueTolerance, Portion satTolerance, Portion valTolerance )
        {
            baseColors = new List<Color>(colors);
        }

        public ColorRow AddColor(Color color)
        {
            //Should we do something to handle duplication here?
            List<Color> newColors = BaseColors;
            newColors.Add(color);
            return new ColorRow(newColors, HueTolerance, SaturationTolerance, ValueTolerance);
        }

        public int IndexOf(Color color)
        {
            for(int i = 0; i < baseColors.Count; i++)
            {
                if(baseColors[i].Equals(color))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
