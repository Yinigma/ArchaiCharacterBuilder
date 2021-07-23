using CharacterCreator.Domain.Project;

namespace CharacterCreator.Domain.Project
{
	public class Hurtbox : IProjectItem
	{
		public int Width { get; private set; }

		public int Height { get; private set; }

		private string source;

		public string Source { get; set; }

		public long Id { get; }
	}

}

