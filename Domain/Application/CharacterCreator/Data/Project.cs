using System;
using System.Collections.Generic;
using System.Linq;
using Group = Domain.Application.CharacterCreator.Data.ProjectItemGroup;

namespace Domain.Application.CharacterCreator.Data
{
    public class Project
    {

        public Group Root { get; private set; } = new Group(0);

        public void AddItem(IProjectItem item, Group targetGroup = null)
        {
            Group group = targetGroup ?? Root;
            group.AddItem(item);
        }

        public IProjectItem GetItem(long id)
        {
            return First( (IProjectItem item) => item.Id == id );
        }

        public IProjectItem First(Func<IProjectItem, bool> predicate)
        {
            return GetAllItems().First(predicate);
        }

        public List<IProjectItem> Where(Func<IProjectItem, bool> predicate)
        {
            return new List<IProjectItem>(GetAllItems().Where(predicate));
        }

        public bool RemoveItem(IProjectItem item)
        {
            foreach(Group group in GetAllItems().Where((projItem) => projItem is Group))
            {
                if(group.RemoveItem(item))
                {
                    return true;
                }
            }
            return false;
        }

        private List<IProjectItem> GetAllItems()
        {
            List<IProjectItem> items = new List<IProjectItem>();
            List<Group> itemGroups = new List<Group>();
            itemGroups.Add(Root);
            while(itemGroups.Count > 0)
            {
                List<Group> tempItemGroups = new List<Group>(itemGroups);
                itemGroups.Clear();
                foreach(Group group in tempItemGroups)
                {
                    items.AddRange(group.Items);
                    items.Where((projItem) => projItem is Group);
                }
            }
            return items;
        }

        public Project Duplicate()
        {
            Project duplicate = new Project();
            duplicate.Root = (Group) Root.Duplicate();
            return duplicate;
        }
    }
}
