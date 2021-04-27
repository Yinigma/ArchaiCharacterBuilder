using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    public class Hurtbox
    {
        string Path { get; }

        public Hurtbox(string path)
        {
            Path = path;
        }

        public bool Equals(Hurtbox other)
        {
            return Path.Equals(other.Path);
        }
    }
}
