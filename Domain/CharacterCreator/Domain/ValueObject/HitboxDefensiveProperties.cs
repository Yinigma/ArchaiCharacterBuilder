namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class HitboxDefensiveProperties
    {
        //Defense Properties - or really anything that defines an oppent's ability to escape from a combo 
        public bool Techable { get; }
        public double DriftMultiplier { get; }
        public double ShiftMultiplier { get; }
        bool ForcesFlinch { get; }

        public HitboxDefensiveProperties(bool techable, double driftMult, double shiftMult, bool forcesFlinch, HitboxHitpause hitpause)
        {
            Techable = techable;
            DriftMultiplier = driftMult;
            ShiftMultiplier = shiftMult;
            ForcesFlinch = forcesFlinch;
        }

        public override bool Equals(object other)
        {
            return other is HitboxDefensiveProperties &&
                Techable == (other as HitboxDefensiveProperties).Techable &&
                DriftMultiplier == (other as HitboxDefensiveProperties).DriftMultiplier &&
                ShiftMultiplier == (other as HitboxDefensiveProperties).ShiftMultiplier &&
                ForcesFlinch == (other as HitboxDefensiveProperties).ForcesFlinch;
        }

        public override int GetHashCode()
        {
            return (Techable, DriftMultiplier, ShiftMultiplier, ForcesFlinch).GetHashCode();
        }
    }
}
