using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Hitbox
{
    public class HitboxDefensiveProperties
    {
        //Defense Properties - or really anything that defines an oppent's ability to escape from a combo 
        public bool Techable { get; }
        public double DriftMultiplier { get; }
        public double ShiftMultiplier { get; }
        bool ForcesFlinch { get; }
        public HitboxHitpause Hitpause { get; }

        public HitboxDefensiveProperties( bool techable, double driftMult, double shiftMult, bool forcesFlinch, HitboxHitpause hitpause)
        {
            Techable = techable;
            DriftMultiplier = driftMult;
            ShiftMultiplier = shiftMult;
            ForcesFlinch = forcesFlinch;
            Hitpause = hitpause;
        }

        public bool Equals(HitboxDefensiveProperties other)
        {
            return Techable == other.Techable && DriftMultiplier == other.DriftMultiplier && ShiftMultiplier == other.ShiftMultiplier && ForcesFlinch == other.ForcesFlinch && Hitpause.Equals(other.Hitpause);
        }
        public HitboxDefensiveProperties Duplicate()
        {
            return new HitboxDefensiveProperties(Techable, DriftMultiplier, ShiftMultiplier, ForcesFlinch, Hitpause);
        }
    }
}
