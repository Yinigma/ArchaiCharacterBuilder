using Archai.CharacterCreator.Domain.Enumeration.Attack;
using Archai.CharacterCreator.Domain.Enumeration.Hitbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class HitboxOffensiveProperties
    {
        //Offensive Properties
        public int Damage { get; }
        public int Priority { get; }
        public bool IgnoresProjectiles { get; }
        public RockBehavior RockBehavior { get; }
        public GroundingCategory Groundedness { get; }
        public HitEffect Effect { get; }

        public HitboxOffensiveProperties(int damage, int priority, bool ignoresProjectiles, RockBehavior rockBehavior, GroundingCategory groundedness, HitEffect effect)
        {
            Damage = damage;
            Priority = priority;
            IgnoresProjectiles = ignoresProjectiles;
            RockBehavior = rockBehavior;
            Groundedness = groundedness;
            Effect = effect;
        }

        public override bool Equals(object other)
        {
            return other is HitboxOffensiveProperties &&
                Damage == (other as HitboxOffensiveProperties).Damage &&
                Priority == (other as HitboxOffensiveProperties).Priority &&
                IgnoresProjectiles == (other as HitboxOffensiveProperties).IgnoresProjectiles &&
                RockBehavior == (other as HitboxOffensiveProperties).RockBehavior &&
                Groundedness == (other as HitboxOffensiveProperties).Groundedness &&
                Effect == (other as HitboxOffensiveProperties).Effect;
        }

        public override int GetHashCode()
        {
            return (Damage, Priority, IgnoresProjectiles, RockBehavior, Groundedness, Effect).GetHashCode();
        }
    }
}
