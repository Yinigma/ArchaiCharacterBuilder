using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Hitbox
{
    public class HitboxHitpause
    {
        //Hitpause
        public int BaseHitpause { get; }
        public int OpponentHitpauseOffset { get; }
        public double HitpauseScaling { get; }
        public double HitstunMultiplier { get; }

        public HitboxHitpause(int baseHitpause, int opponentHitpauseOffset, double hitpauseScaling, double hitstunMultiplier)
        {
            BaseHitpause = baseHitpause;
            OpponentHitpauseOffset = opponentHitpauseOffset;
            HitpauseScaling = hitpauseScaling;
            HitstunMultiplier = hitstunMultiplier;
        }

        public bool Equals(HitboxHitpause other)
        {
            return BaseHitpause == other.BaseHitpause && OpponentHitpauseOffset == other.OpponentHitpauseOffset && HitpauseScaling == other.HitpauseScaling && HitstunMultiplier == other.HitstunMultiplier;
        }

        public HitboxHitpause Duplicate()
        {
            return new HitboxHitpause(BaseHitpause, OpponentHitpauseOffset, HitpauseScaling, HitstunMultiplier);
        }
    }
}
