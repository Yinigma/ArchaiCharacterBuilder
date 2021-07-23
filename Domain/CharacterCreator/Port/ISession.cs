using Archai.CharacterCreator.Domain.Entity;

namespace CharacterCreator.Port
{
    public interface ISession
	{
		long AddProject(Project project);

		Project GetProject(int index);

		void CloseProject();

		void ReplaceProject(Project project);

	}

}

