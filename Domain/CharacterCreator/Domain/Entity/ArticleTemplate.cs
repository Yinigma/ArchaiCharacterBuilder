using Archai.CharacterCreator.Domain.ValueObject.Script;
using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class ArticleTemplate : IProjectItem
    {
        public Properties CustomProperties { get; } = new Properties();

        private IList<IScript> initScripts = new List<IScript>();

        public void InsertInitScript(int index, IScript script)
        {
            initScripts.Insert(index, script);
        }

        public void RemoveInitScript(int index)
        {
            initScripts.RemoveAt(index);
        }

        private IList<IScript> updateScripts = new List<IScript>();

        public void InsertUpdateScript(int index, IScript script)
        {
            updateScripts.Insert(index, script);
        }

        public void RemoveUpdateScript(int index)
        {
            updateScripts.RemoveAt(index);
        }

        public long Id { get; }
    }
}

