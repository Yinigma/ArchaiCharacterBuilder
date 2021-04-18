using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public class ColorRow
    {
        public float HueTolerance;
        private float saturationTolerance;
        private float valueTolerance;

        private List<Color> baseColors = new List<Color>();

        internal void AddColor()
        {
            baseColors.Add(new Color());
        }

        internal void RemoveColor(int colorDex)
        {
            baseColors.RemoveAt(colorDex);
        }

        internal void SetColor(int index, Color color)
        {
            baseColors[index] = color;
        }

        internal Color GetColor(int profileDex)
        {
            return baseColors[profileDex];
        }
    }
}
