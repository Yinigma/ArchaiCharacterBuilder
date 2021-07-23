using Archai.CharacterCreator.Domain.Enumeration.Attack;
using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Attack : IProjectItem
    {
        public SpriteSequence AttackAnimation { get; set; }
        public HurtboxSequence HurtboxSequence { get; set; }
        private IList<Window> windows = new List<Window>();
        public void InsertWindow(int index, Window window)
        {
            windows.Insert(index, window);
        }

        public void RemoveWindow(int index)
        {
            windows.RemoveAt(index);
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

        public string AttackName { get; set; }
        public string Description { get; set; }
        public AttackType AttackType { get; set; }
        public GroundingCategory Groundedness { get; set; }
        public bool HasLandingLag { get; set; }
        public bool OffLedge { get; set; }
        public bool CustomGravity { get; set; }
        public long Id { get; }

        internal Attack(long id)
        {
            Id = id;
        }
    }
}

