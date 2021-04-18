namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterEvasionData
    {
        public FighterActionWindow SpotDodge { get; set; }

        public FighterTechData TechData { get; set; }

        public FighterAirDodge AirDodge { get; set; }

        public FighterRollData RollData { get; set; }

        public FighterActionWindow Crouch { get; set; }
    }
}
