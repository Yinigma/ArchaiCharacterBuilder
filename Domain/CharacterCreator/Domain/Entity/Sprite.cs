using CharacterCreator.Domain.Project;

namespace CharacterCreator.Domain.Project
{
	public class Sprite : IProjectItem
	{
		public int Width;

		public int Height;

		public string Source;


		/// <see>CharacterCreator.Domain.Project.IProjectItem#Id()</see>
		public long Id()
		{
			return 0;
		}

	}

}

