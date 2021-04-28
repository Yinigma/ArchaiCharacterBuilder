using Domain.Core.Enum.Attack;
using Domain.Core.ValueObjects.Attack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    class ProjectAttack : IProjectItem
    {
        public string Name { get; internal set; }

        public long Id { get; }

        public AttackConfiguration Configuration { get; set; }

        private IList<ProjectWindow> windows = new List<ProjectWindow>();

        public IList<ProjectWindow> Windows 
        {
            get 
            {
                return new List<ProjectWindow>(windows);
            }
        }

        private ProjectAttack(long id, string name, AttackConfiguration configuration, List<ProjectWindow> projectWindows)
        {
            Id = id;
        }

        public static ProjectAttack CreateNew(long id, string name)
        {
            return new ProjectAttack
            (
                id,
                name,
                new AttackConfiguration
                (
                    AttackType.UNASSIGNED,
                    GroundingCategory.EITHER,
                    false,
                    false,
                    false,
                    //TODO - what does it mean?
                    null
                ),
                new List<ProjectWindow>()
            );
        }

        public IProjectItem Duplicate(long duplicateId)
        {
            throw new NotImplementedException();
        }
    }
}
