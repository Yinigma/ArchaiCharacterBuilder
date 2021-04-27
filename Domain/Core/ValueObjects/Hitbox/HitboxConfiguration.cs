using Domain.Core.Enum.Attack;
using Domain.Core.Enum.Hitbox;
using Domain.Core.ValueObjects;
using Domain.Core.ValueObjects.Hitbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    public class HitboxConfiguration
    {
        public HitboxConfiguration Parent { get; }
        public HitboxLifetime Lifetime { get; }
        public HitboxShape Shape { get; }
        public HitboxOffensiveProperties OffensiveProperties { get; }
        public HitboxDefensiveProperties DefensiveProperties { get; }
        public HitboxKnockback Knockback { get; }
        public bool DistanceParry { get; }

        

        public HitboxConfiguration
        (
            HitboxConfiguration parent,
            HitboxLifetime lifetime,
            HitboxShape shape,
            HitboxOffensiveProperties offensiveProperties,
            HitboxDefensiveProperties defensiveProperties,
            HitboxKnockback knockback,
            bool distanceParry
        )
        {
            Parent = parent;
            Lifetime = lifetime;
            Shape = shape;
            OffensiveProperties = offensiveProperties;
            DefensiveProperties = defensiveProperties;
            Knockback = knockback;
            DistanceParry = distanceParry;
        }

        public bool Equals(HitboxConfiguration other)
        {
            return
                Parent == other.Parent &&
                Lifetime == other.Lifetime &&
                Shape == other.Shape &&
                OffensiveProperties == other.OffensiveProperties &&
                DefensiveProperties == other.DefensiveProperties &&
                Knockback == other.Knockback &&
                DistanceParry == other.DistanceParry;
        }

        public HitboxConfiguration Duplicate()
        {
            return new HitboxConfiguration
            (
                Parent,
                Lifetime,
                Shape,
                OffensiveProperties,
                DefensiveProperties,
                Knockback,
                DistanceParry
            );
        }

        //Feedback
        //public Sprite VisualEffect { get; }
        //public SoundEffect HitSound { get; }
        //public CameraBehavior CamShake { get; }
    }
}
