using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public interface IProjectItem
    {
        string Name { get;  }

        long Id { get; }

        IProjectItem Duplicate();
    }
}
