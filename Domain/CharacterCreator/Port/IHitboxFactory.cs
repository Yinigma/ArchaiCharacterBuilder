using Archai.CharacterCreator.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Port
{
    public interface IHitboxFactory
    {
        Hitbox CreateHitbox();
    }
}
