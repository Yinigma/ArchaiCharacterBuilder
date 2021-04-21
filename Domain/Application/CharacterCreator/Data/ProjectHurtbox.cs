using Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    class ProjectHurtbox : Hurtbox, IProjectItem
    {
        public string Name { get; set; }
    }
}
