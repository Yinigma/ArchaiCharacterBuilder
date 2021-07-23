using Archai.CharacterCreator.Domain.ValueObject.Script;
using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Article : IProjectItem
    {
        public Properties ArticleProperties { get; private set; }

        private List<IScript> updateScripts;

        public long Id { get; }

    }

}

