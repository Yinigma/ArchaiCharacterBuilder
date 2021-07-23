using Archai.CharacterCreator.Domain.Enumeration.Attack;
using Archai.CharacterCreator.Domain.Enumeration.Hitbox;
using Archai.CharacterCreator.Domain.ValueObject;
using CharacterCreator.Domain.Project;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Hitbox : IProjectItem
    {
        //Lifetime
        /*public int StartFrame { get; internal set; }
        public int Lifetime { get; internal set; }
        public int HitLockoutDuration { get; set; }

        //Hitpause
        public int BaseHitpause { get; }
        public int OpponentHitpauseOffset { get; }
        public double HitpauseScaling { get; }
        public double HitstunMultiplier { get; }

        //Defensive properties
        public bool Techable { get; }
        public double DriftMultiplier { get; }
        public double ShiftMultiplier { get; }
        public bool ForcesFlinch { get; }

        //Offensive Properties
        public int Damage { get; }
        public int Priority { get; }
        public bool IgnoresProjectiles { get; }
        public RockBehavior RockBehavior { get; }
        public GroundingCategory Groundedness { get; }
        public HitEffect Effect { get; }

        //Shape
        public Vector2 Position { get; }
        public Vector2 Size { get; }
        public HitboxShapeType Shape { get; }

        //Knockback
        public Angle KnockbackDirection { get; }
        public double BaseKnockback { get; }
        public double KnockbackScaling { get; }
        public int EndOfLifetimeKnockback { get; }
        public AngleBehavior AngleBehavior { get; }*/


        public long Id { get; }

    }

}

