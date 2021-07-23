using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class GridType : DataStructureType
    {
        IScriptVariableType NestedType { get; }

        public GridType(IScriptVariableType nestedType)
        {
            NestedType = nestedType;
        }

        public override bool Assignable(Type valueType)
        {
            return valueType.IsArray && valueType.GetArrayRank() == 2 && NestedType.Assignable(valueType.GetElementType());
        }
    }
}
