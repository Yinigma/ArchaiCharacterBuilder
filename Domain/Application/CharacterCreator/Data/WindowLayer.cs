using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    abstract internal class WindowLayer
    {
        public long Id { get; }
        public string Name { get; set; } = "New Layer";
        public bool Locked { get; set; } = false;
        public bool Visible { get; set; } = true;

        //internal IList<ProjectHitbox> hitboxes = new List<ProjectHitbox>();

        internal WindowLayer(long id)
        {
            Id = id;
        }

        abstract internal WindowLayer Duplicate();
    }
}
