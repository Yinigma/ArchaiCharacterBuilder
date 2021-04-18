using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    class Hitbox
    {
        public Hitbox ValueParent { get; set; }

        public int StartFrame { get; set; }

        public int Lifetime { get; set; }

        public Point Position { get; set; }

        public Point Size { get; set; }

        public HitboxShape Shape { get; set; }

        public int Priority { get; set; }

        public int Damage { get; set; }

        public int Angle { get; set; }

        public float BaseKnockback { get; set; }

        public float KnockbackScaling { get; set; }

        public HitEffect Effect { get; set; }

        public int BaseHitpause { get; set; }

        public float HitpauseScaling { get; set; }

        public int VisualEffectSpriteId { get; set; }

        public int HitSoundId { get; set; }

        public AngleBehavior AngleBehavior { get; set; }

        public int OpponentHitpauseOffset { get; set; }

        public GroundCategory Groundedness { get; set; }

        public CameraBehavior CamShake { get; set; }

        public bool IgnoresProjectiles { get; set; }

        public int HitLockoutDuration { get; set; }

        public bool DistanceParry { get; set; }

        public float HitstunMultiplier { get; set; }

        public float DriftMultiplier { get; set; }

        public float ShiftDIMultiplier { get; set; }

        public bool Techable { get; set; }

        public bool ForceFlinch { get; set; }

        public int EndOfLifetimeKnockback { get; set; }

        public RockBehavior RockBehavior { get; set; }
    }
}
