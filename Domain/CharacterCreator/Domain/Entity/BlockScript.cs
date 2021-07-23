using CharacterCreator.Domain.Project;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class BlockScript : IScript
    {
        public CodeBlock EntryBlock;

        public long Id { get; }
    }

}

