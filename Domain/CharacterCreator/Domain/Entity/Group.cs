using CharacterCreator.Domain.Project;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Group : IProjectItem
    {
        private ISet<IProjectItem> items = new HashSet<IProjectItem>();
        public IList<IProjectItem> Items 
        {
            get 
            {
                return new List<IProjectItem>(items);
            }
        }

        internal void AddItem(IProjectItem item)
        {
            items.Add(item);
        }

        internal void RemoveItem(IProjectItem item)
        {
            items.Remove(item);
        }

        internal IProjectItem GetItem(long itemId)
        {
            foreach(IProjectItem item in items)
            {
                if(item is Group)
                {
                    IProjectItem groupItem = (item as Group).GetItem(itemId);
                    if(groupItem != null)
                    {
                        return groupItem;
                    }
                }
                if(item.Id == itemId)
                {
                    return item;
                }
            }
            return null;
        }

        public long Id { get; }

        public Group(long id)
        {
            Id = id;
        }

    }

}

