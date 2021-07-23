using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
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

        public override bool Equals(object other)
        {
            return BaseHitpause == other.BaseHitpause && OpponentHitpauseOffset == other.OpponentHitpauseOffset && HitpauseScaling == other.HitpauseScaling && HitstunMultiplier == other.HitstunMultiplier;
        }

        public override int GetHashCode()
        {
            return (BaseHitpause, OpponentHitpauseOffset, HitpauseScaling, HitstunMultiplier).GetHashCode();
        }
    }
}
