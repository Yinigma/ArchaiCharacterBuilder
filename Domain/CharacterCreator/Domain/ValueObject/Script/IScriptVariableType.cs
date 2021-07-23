using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public interface IScriptVariableType
    {
        bool Assignable(Type valueType);
    }
}
