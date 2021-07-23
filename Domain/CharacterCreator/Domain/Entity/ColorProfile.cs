using Domain.Core.Exceptions;
using Domain.Core.ValueObjects;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class ColorProfile
    {
        private Color[][] profileColors;
        private string[] profileNames;
        private ColorTolerance[] baseColorTolerance;

        public Color[][] Colors
        {
            get
            {
                Color[][] colorArr = new Color[profileColors.Length][];
                for (int nameDex = 0; nameDex < colorArr.Length; nameDex++)
                {
                    colorArr[nameDex] = (Color[])profileColors[nameDex].Clone();
                }
                return colorArr;
            }
        }


        public ColorProfile(string[] names, ColorTolerance[] baseTolerance, Color[][] colors)
        {
            if (baseTolerance.Length > 8)
            {
                throw new ColorLimitExceededException();
            }
            profileNames = (string[])names.Clone();
            baseColorTolerance = (ColorTolerance[])baseTolerance.Clone();
            profileColors = new Color[profileNames.Length][];
            for (int nameIndex = 0; nameIndex < profileNames.Length; nameIndex++)
            {
                profileColors[nameIndex] = new Color[baseColorTolerance.Length];
                for (int tolIndex = 0; tolIndex < baseColorTolerance.Length; tolIndex++)
                {
                    profileColors[nameIndex][tolIndex] = nameIndex >= colors.Length || tolIndex >= colors[nameIndex].Length ? Color.White : colors[nameIndex][tolIndex];
                }
            }
        }

        public bool Equals(ColorProfile other)
        {
            if (profileNames.Length != other.profileNames.Length || baseColorTolerance.Length != baseColorTolerance.Length)
            {
                return false;
            }
            for (int i = 0; i < profileNames.Length; i++)
            {
                if (!profileNames[i].Equals(other.profileNames[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < baseColorTolerance.Length; i++)
            {
                if (!baseColorTolerance[i].Equals(other.baseColorTolerance[i]))
                {
                    return false;
                }
            }
            for (int r = 0; r < profileNames.Length; r++)
            {
                for (int c = 0; c < baseColorTolerance.Length; c++)
                {
                    if (!profileColors[r][c].Equals(other.profileColors[r][c]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
