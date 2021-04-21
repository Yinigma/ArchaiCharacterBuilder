using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    public interface IProjectItem
    {
        string Name { get; }

        long Id { get; }
    }
}
