using CharacterCreator.Domain.Project;
using System.Collections.Generic;
using CharacterCreator.Port;

namespace CharacterCreator.Port
{
	public interface IStaticAnalyzer<S>
	    where S : IScript
	{
		List analyzeSource(S script);

	}

}

