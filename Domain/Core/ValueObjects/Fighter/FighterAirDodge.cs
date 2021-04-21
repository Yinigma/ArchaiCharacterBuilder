namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterAirDodge
    {
        public FighterActionWindow AirDodge { get; }
        public double AirDodgeSpeed { get; }

        public FighterAirDodge(FighterActionWindow window, double dodgeSpeed)
        {
            AirDodge = window;
            AirDodgeSpeed = dodgeSpeed;
        }

        public FighterAirDodge Duplicate()
        {
            return new FighterAirDodge(AirDodge.Duplicate(), AirDodgeSpeed);
        }

        public bool Equals(FighterAirDodge other)
        {
            return AirDodge.Equals(other.AirDodge) && AirDodgeSpeed == other.AirDodgeSpeed;
        }
    }
}
