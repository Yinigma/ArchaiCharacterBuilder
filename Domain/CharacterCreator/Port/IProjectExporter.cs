using Archai.CharacterCreator.Domain.Entity;

namespace CharacterCreator.Port
{
    public interface IProjectExporter
	{
		void ExportProject(string location, Project project);

	}

}

