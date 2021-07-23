using System.Collections.Generic;
using Archai.CharacterCreator.Domain.ValueObject.Script;

namespace Archai.CharacterCreator.Domain.Entity
{
    public abstract class CodeBlock
    {
        private Properties properties;
        private Dictionary<string, BlockArgument> blockArguments;

        public void SetArgument(string name, BlockArgument obj)
        {
            properties.SetArgument(name, obj.ArgumentValue);
            blockArguments[name] = obj;
        }

    }

}

