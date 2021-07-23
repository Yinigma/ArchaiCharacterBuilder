using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class HitboxConfiguration
    {
        public HitboxConfiguration Parent { get; }
        public HitboxLifetime Lifetime { get; }
        public HitboxShape Shape { get; }
        public HitboxOffensiveProperties OffensiveProperties { get; }
        public HitboxDefensiveProperties DefensiveProperties { get; }
        public HitboxHitpause Hitpause { get; }
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

        public override bool Equals(object other)
        {
            return 
                Parent == (other as HitboxConfiguration).Parent &&
                Lifetime == (other as HitboxConfiguration).Lifetime &&
                Shape == (other as HitboxConfiguration).Shape &&
                OffensiveProperties == (other as HitboxConfiguration).OffensiveProperties &&
                DefensiveProperties == (other as HitboxConfiguration).DefensiveProperties &&
                Knockback == (other as HitboxConfiguration).Knockback &&
                DistanceParry == (other as HitboxConfiguration).DistanceParry;
        }

        public override int GetHashCode()
        {
            return (Parent, Lifetime, Shape, OffensiveProperties, DefensiveProperties, Knockback, DistanceParry).GetHashCode();
        }

        //Feedback
        //public Sprite VisualEffect { get; }
        //public SoundEffect HitSound { get; }
        //public CameraBehavior CamShake { get; }
    }
}
