using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    internal class HitboxLayer : WindowLayer
    {
        internal IList<ProjectHitbox> Hitboxes = new List<ProjectHitbox>();
        internal HitboxLayer(long id) : base(id) { }
    }
}
