using CharacterCreator.Domain.Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class BlockBranch : IBlockBranch
    {
        public string Name { get; }
        public StatementBlock EntryStatement { get; }

        public BlockBranch(string name, StatementBlock entry)
        {
            Name = name;
            EntryStatement = entry;
        }

        public override bool Equals(object other)
        {
            return other is BlockBranch &&
            (other as BlockBranch).Name.Equals(Name) && 
            (other as BlockBranch).EntryStatement.Equals(EntryStatement);
        }

        public override int GetHashCode() => (Name, EntryStatement).GetHashCode();
    }
}
