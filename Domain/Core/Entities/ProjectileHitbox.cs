using Domain.Core.Enum.Hitbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    class ProjectileHitbox : Hitbox
    {
        public Sprite ProjectileSpriteId { get; set; }

        public Sprite CollisionMaskSpriteId { get; set; }

        public float AnimationSpeed { get; set; }

        public int SpeedX { get; set; }

        public int SpeedY { get; set; }

        public float Gravity { get; set; }

        public float GroundFriction { get; set; }

        public float AirFriction { get; set; }

        public ProjectileSurfaceBehavior WallBehavior { get; set; }

        public ProjectileSurfaceBehavior GroundBehavior { get; set; }

        public ProjectileEnemyBehavior EnemyBehavior { get; set; }

        public bool OriUnbashable { get; set; }

        public bool ParryStunsOwner { get; set; }

        public bool DoesNotReflect { get; set; }

        public bool Unbreakable { get; set; }

        public int DestroySprite { get; set; }
    }
}
