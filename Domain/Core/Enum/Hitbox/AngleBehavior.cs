using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Enum.Hitbox
{
    public enum AngleBehavior
    {
        CONSTANT,
        AWAY_FROM_ENEMY_CENTER,
        TOWARDS_ENEMY_CENTER,
        HORIZONTAL_AWAY_FROM_HITBOX,
        HORIZONTAL_TOWARDS_HITBOX,
        REVERSED_HORIZONTAL,
        HORIZONTAL_AWAY_FROM_ENEMY,
        HORIZONTAL_TOWARDS_ENEMY,
        SENDS_AWAY_FROM_CENTER_OF_HITBOX,
        SENDS_TOWARD_CENTER_OF_HITBOX,
    }
}
