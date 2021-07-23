using System.Linq;
using System.Collections.Generic;
using System.Text;
using Archai.CharacterCreator.Domain.Exceptions;
using System;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public class Properties
    {
        private Dictionary<Parameter, object> state = new Dictionary<Parameter, object>();

        public void AddParameter(string name, IScriptVariableType type)
        {
            if(state.Keys.Any((curParam)=>curParam.Name.Equals(name)))
            {
                throw new DuplicateParameterNameException();
            }
            state.Add(new Parameter(name, type), null);
        }

        public void RemoveParameter(string name)
        {
            Parameter param = state.Keys.First((curParam) => curParam.Name.Equals(name));
            if(param == null)
            {
                throw new ParameterNotFoundException();
            }
            state.Remove(param);
        }

        public void SetArgument(string name, object property)
        {
            Parameter param = state.Keys.First((curParam)=>curParam.Name.Equals(name) );
            if (param == null)
            {
                throw new ParameterNotFoundException();
            }
            if (!param.ParameterType.Assignable(property.GetType()))
            {
                throw new ArgumentException("Object of type \"" +property.GetType().Name + "\" does not match the given parameter.", name);
            }
        }
    }
}
