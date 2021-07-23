using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Project
    {
        public Group Root { get; } = new Group(0);
        private ISet<IProjectItem> items = new HashSet<IProjectItem>(); 

        public void AddItem(Group target, IProjectItem item)
        {
            items.Add(item);
            target.AddItem(item);
        }

        public void RemoveItem(Group target, IProjectItem item)
        {
            target.RemoveItem(item);
            //Remove if this is the last remaining instance
            if(Root.GetItem(item.Id)!=null)
            {
                items.Remove(item);
            }
        }

        public Fighter GetFighter(long fighterId)
        {
            foreach(IProjectItem projectItem in items)
            {
                if (projectItem is Fighter && projectItem.Id == fighterId)
                {
                    return projectItem as Fighter;
                }
            }
            throw new ProjectItemTypeMismatchException();
        }

        public long Id { get; }

        public Project(long id)
        {
            Id = id;
        }
    }

}

