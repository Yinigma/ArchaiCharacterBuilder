using CharacterCreator.Port;
using Archai.CharacterCreator.Domain.Entity;

namespace CharacterCreator.Port
{
    public interface IProjectRepository<L>
	{
		void LoadProject(L path);

		void SaveProject(L path);

		L GetLocator(Project project);

	}

}

