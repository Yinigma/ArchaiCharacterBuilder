
using Domain.Core.ValueObjects;
using System.Collections.Generic;

namespace Domain.Core.Entities
{
    public class ColorProfile
    {
        //Up to 8 different colors in a slot
        public IList<ColorRow> ColorRows = new List<ColorRow>();
        public IList<string> Profiles = new List<string>();

        public void AddColor(Color baseColor)
        {
            ColorRows.Add(new ColorRow(new List<Color>(){baseColor}, new Angle(0), new Portion(0), new Portion(0) ) );
        }

        public void SetColor(Color baseColor, int row, string profile)
        {
            int profileDex = Profiles.IndexOf(profile);
            if(profileDex != -1)
            {
                ColorRows[row]?.SetColor(profileDex, baseColor);
            }
        }

        public Color GetColor(int row, string profile)
        {
            int profileDex = Profiles.IndexOf(profile);
            if (profileDex != -1)
            {
                return ColorRows[row].BaseColors[profileDex];
            }
            return null;
        }

        public void RemoveColor( int row )
        {
            ColorRows.RemoveAt(row);
        }

        public void AddProfileSlot(string name)
        {
            Profiles.Add(name);
            foreach(ColorRow row in ColorRows)
            {
                row.AddColor(Color.createFromRGB(UnsignedPortion.Max, UnsignedPortion.Max, UnsignedPortion.Max));
            }
        }

        public void RemoveProfileSlot(string toRemove)
        {
            int index = Profiles.IndexOf(toRemove);
            foreach(ColorRow row in ColorRows)
            {
                row.RemoveColor(index);
            }
            Profiles.RemoveAt(index);
        }
    }
}
