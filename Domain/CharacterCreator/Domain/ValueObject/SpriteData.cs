using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class SpriteData
    {
        public uint Width { get; }

        public uint Height { get; }

        public Color[,] Data { get; }

        public SpriteData(uint width, uint height, Color[,] data)
        {
            Width = width;
            Height = height;
            if(data.Length != width * height)
            {

            }
            Data = new Color[width, height];
            Array.Copy(data, Data, width * height);
        }
    }
}
