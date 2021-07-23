using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class PixelMask
    {
        public uint Width;

        public uint Height;

        public bool[,] Mask { get; }

        public PixelMask( uint width, uint height, bool[,] mask)
        {
            Width = width;
            Height = height;
            if(mask.Length != width*height)
            {
                //TODO throw an exception
            }
            Mask = new bool[width, height];
            Array.Copy(mask, Mask, width * height);
        }
    }
}
