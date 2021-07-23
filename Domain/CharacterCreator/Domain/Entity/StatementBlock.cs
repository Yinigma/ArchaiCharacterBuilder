using Archai.CharacterCreator.Domain.Entity;
using Archai.CharacterCreator.Domain.ValueObject.Script;

namespace CharacterCreator.Domain.Project
{
    public abstract class StatementBlock : CodeBlock
	{
		public StatementBlock NextBlock { get; set; }

	}

}

