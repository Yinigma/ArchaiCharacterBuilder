using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects
{
    public class SoundEffect
    {
        public string Path { get; }
        
        public SoundEffect(string path)
        {
            Path = path;
        }

        public bool Equals(SoundEffect other)
        {
            return Path.Equals(other.Path);
        }
    }
}
