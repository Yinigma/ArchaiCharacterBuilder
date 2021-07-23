using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class ArrayType : DataStructureType
    {
        IScriptVariableType NestedType { get; }

        public ArrayType(IScriptVariableType type)
        {
            NestedType = type;
        }

        public override bool Assignable(Type valueType)
        {
            return valueType.IsArray && valueType.GetArrayRank() == 1 && NestedType.Assignable(valueType.GetElementType());
        }
    }
}
