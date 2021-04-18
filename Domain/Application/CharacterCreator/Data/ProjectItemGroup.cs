using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    public class ProjectItemGroup : IProjectItem
    {

        public string Name { get; private set; }

        public long Id { get; private set; }

        public void AddItem(IProjectItem item)
        {
            items.Add(item);
        }

        public bool RemoveItem(IProjectItem item)
        {
            return items.Remove(item);
        }



        public IProjectItem Duplicate()
        {
            ProjectItemGroup duplicate = new ProjectItemGroup(Id);
            foreach(IProjectItem item in Items)
            {
                duplicate.items.Add(item);
            }
            return duplicate;
        }

        public ProjectItemGroup(long id)
        {
            Id = id;
        }

        public List<IProjectItem> Items { get => new List<IProjectItem>(items); }

        private List<IProjectItem> items = new List<IProjectItem>();
    }
}
