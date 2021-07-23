using CharacterCreator.Port;
using System.Collections.Generic;

namespace CharacterCreator.Application.SessionUseCases
{
	public interface ISessionManager : IProjectEditor, ISession
	{
		List<Project> OpenProjects;

	}

}

