using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class Parameter
    {
        public string Name { get; }
        public IScriptVariableType ParameterType { get; }

        public Parameter(string name, IScriptVariableType type)
        {
            Name = name;
            ParameterType = type;
        }

        public override bool Equals(object other)
        {
            return other is Parameter && Name.Equals((other as Parameter).Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
