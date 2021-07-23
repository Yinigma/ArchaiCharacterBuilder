using CharacterCreator.Domain.Project;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class MultiBlockBranch
    {
        public string Name { get; }
        public StatementBlock[] entrySlots;

        public StatementBlock GetBranchStatement(int index)
        {
            return entrySlots[index];
        }

        public MultiBlockBranch AddBranch(MultiBlockBranch initial)
        {
            StatementBlock[] appendEntries = new StatementBlock[initial.entrySlots.Length + 1];
            initial.entrySlots.CopyTo(appendEntries, 0);
            return new MultiBlockBranch(Name, appendEntries);
    }

        public MultiBlockBranch(string name, StatementBlock[] entrySlots)
        {
            Name = name;
            this.entrySlots = entrySlots;
        }

        public override bool Equals(object other)
        {
            return other is BlockBranch &&
            (other as BlockBranch).Name.Equals(Name) &&
            (other as BlockBranch).EntryStatement.Equals(entrySlots);
        }

        public override int GetHashCode() => (Name, entrySlots).GetHashCode();
    }
}
