using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Core.Entities
{
    public class ColorProfile : Entity
    {
        //Up to 8 different colors in a slot
        public IList<ColorRow> ColorRows = new List<ColorRow>();
        public IList<string> Profiles = new List<string>();

        public void AddColor(Color baseColor)
        {
            ColorRows.Add( new ColorRow() );
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
                return ColorRows[row].GetColor(profileDex);
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
                row.AddColor();
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
