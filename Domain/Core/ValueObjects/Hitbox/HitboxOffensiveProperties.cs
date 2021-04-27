using Domain.Core.Enum.Attack;
using Domain.Core.Enum.Hitbox;

namespace Domain.Core.ValueObjects.Hitbox
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
        
        public bool Equals(HitboxOffensiveProperties other)
        {
            return
                Damage == other.Damage &&
                Priority == other.Priority &&
                IgnoresProjectiles == other.IgnoresProjectiles &&
                RockBehavior == other.RockBehavior &&
                Groundedness == other.Groundedness &&
                Effect == other.Effect;
        }

        public HitboxOffensiveProperties Duplicate()
        {
            return new HitboxOffensiveProperties
            (
                Damage,
                Priority,
                IgnoresProjectiles,
                RockBehavior,
                Groundedness,
                Effect
            );
        }
    }
}
