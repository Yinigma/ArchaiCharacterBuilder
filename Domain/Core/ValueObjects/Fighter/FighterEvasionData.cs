namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterEvasionData
    {
        public FighterActionWindow Parry { get; }

        public FighterTechData TechData { get; }

        public FighterAirDodge AirDodge { get; }

        public FighterRollData RollData { get; }

        public FighterActionWindow Crouch { get; }

        public FighterEvasionData(FighterActionWindow parry, FighterTechData techData, FighterAirDodge airDodge, FighterRollData rollData, FighterActionWindow crouch)
        {
            Parry = parry;
            TechData = techData;
            AirDodge = airDodge;
            RollData = rollData;
            Crouch = crouch;
        }

        public bool Equals(FighterEvasionData other)
        {
            return 
                Parry.Equals(other.Parry) &&
                TechData.Equals(other.TechData) &&
                AirDodge.Equals(other.AirDodge) &&
                RollData.Equals(other.RollData) &&
                Crouch.Equals(other.Crouch);
        }

        public FighterEvasionData Duplicate()
        {
            return new FighterEvasionData
            (
                Parry.Duplicate(),
                TechData.Duplicate(),
                AirDodge.Duplicate(),
                RollData.Duplicate(),
                Crouch.Duplicate()
            );
        }
    }
}
