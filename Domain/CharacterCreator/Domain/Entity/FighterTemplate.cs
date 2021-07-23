using Archai.CharacterCreator.Domain.ValueObject.Script;
using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class FighterTemplate : IProjectItem
    {
        private Properties TemplateProperties { get; } = new Properties();

        public long Id { get; }

        public string Name { get; }

        public FighterTemplate(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }

}

