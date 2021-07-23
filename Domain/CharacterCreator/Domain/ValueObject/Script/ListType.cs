using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class ListType : DataStructureType
    {
        IScriptVariableType NestedType { get; }

        public ListType(IScriptVariableType type)
        {
            NestedType = type;
        }

        public override bool Assignable(Type valueType)
        {
            return valueType.GetInterfaces().Contains(typeof(IList<>)) && NestedType.Assignable(valueType.GetGenericArguments()[0]);
        }
    }
}
