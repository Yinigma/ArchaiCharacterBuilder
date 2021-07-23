using CharacterCreator.Port;
using Archai.CharacterCreator.Domain.Entity;

namespace CharacterCreator.Application.SessionUseCases
{
    public class ProjectPersistenceInteractor<L>
	{
		private IProjectEditor manager;

		public void CreateProject(long id)
		{

		}

		public Project LoadProject(L locator)
		{
			return null;
		}

		public void SaveProject(Project project)
		{

		}

		public void RevertProject(Project project)
		{

		}

		public void CloseProject(Project project)
		{

		}

	}

}

