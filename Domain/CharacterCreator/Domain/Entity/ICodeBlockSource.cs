using Archai.CharacterCreator.Domain.Entity;
using System.Collections.Generic;

namespace CharacterCreator.Port
{
	public interface ICodeBlockSource
	{
		List<CodeBlock> GetAvailableCodeBlocks();
	}

}

