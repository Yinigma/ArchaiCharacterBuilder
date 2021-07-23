using Archai.CharacterCreator.Domain.Enumeration.Script;
using System.Runtime;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public abstract class DataStructureType : IScriptVariableType
    {
        public abstract bool Assignable(Type valueType);
    }
}
