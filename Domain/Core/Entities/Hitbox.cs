using Domain.Core.Enum.Attack;
using Domain.Core.Enum.Hitbox;
using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    public abstract class Hitbox
    {
        public long Id { get; set; }

        public Hitbox ValueParent { get; set; }

        //Lifetime
        public int StartFrame { get; set; }
        public int Lifetime { get; set; }
        public int HitLockoutDuration { get; set; }

        //Dimensions
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public HitboxShape Shape { get; set; }

        //Knockback
        public Angle Angle { get; set; }
        public float BaseKnockback { get; set; }
        public float KnockbackScaling { get; set; }
        public int EndOfLifetimeKnockback { get; set; }
        public AngleBehavior AngleBehavior { get; set; }

        //Offensive Properties
        public int Damage { get; set; }
        public int Priority { get; set; }
        public bool IgnoresProjectiles { get; set; }
        public bool ForceFlinch { get; set; }
        public RockBehavior RockBehavior { get; set; }

        //DI
        public float DriftMultiplier { get; set; }
        public float ShiftDIMultiplier { get; set; }

        //Hitpause
        public int BaseHitpause { get; set; }
        public int OpponentHitpauseOffset { get; set; }
        public float HitpauseScaling { get; set; }
        public float HitstunMultiplier { get; set; }

        //Defense Properties
        public bool Techable { get; set; }
        public bool DistanceParry { get; set; }

        //Feedback
        public Sprite VisualEffect { get; set; }
        public SoundEffect HitSound { get; set; }
        public CameraBehavior CamShake { get; set; }
        public HitEffect Effect { get; set; }
        public GroundCategory Groundedness { get; set; }
    }
}
