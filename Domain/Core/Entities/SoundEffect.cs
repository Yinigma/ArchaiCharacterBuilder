using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    class SoundEffect
    {
        long Id { get; }
        
        public SoundEffect(long id)
        {
            Id = id;
        }
    }
}
