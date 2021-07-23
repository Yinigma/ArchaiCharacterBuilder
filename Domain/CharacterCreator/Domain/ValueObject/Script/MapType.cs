using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class MapType : DataStructureType
    {
        IScriptVariableType KeyType { get; }

        IScriptVariableType ValueType { get; }

        public MapType(IScriptVariableType keyType, IScriptVariableType valueType)
        {
            KeyType = keyType;
            ValueType = valueType;
        }

        public override bool Assignable(Type valueType)
        {
            return valueType.GetInterfaces().Contains(typeof(IDictionary<,>)) && KeyType.Assignable(valueType.GetGenericArguments()[0]) && ValueType.Assignable(valueType.GetGenericArguments()[1]);
        }
    }
}
