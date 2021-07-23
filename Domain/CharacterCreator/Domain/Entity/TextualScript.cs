using CharacterCreator.Domain.Project;

namespace CharacterCreator.Domain.Project
{
	public class TextualScript : IScript
	{
		public string Source;

		public long Id { get; }

		public TextualScript(long id)
        {
			Id = id;
        }
	}

}

