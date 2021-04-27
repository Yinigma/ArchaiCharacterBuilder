namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterEvasionData
    {
        public double TechrollSpeed { get; }
        public double AirDodgeSpeed { get; }
        public double RollForwardMax { get; }
        public double RollBackwardMax { get; }

        public FighterEvasionData(double techrollSpeed, double airDodge, double rollForwardMax, double rollBackwardMax)
        {
            TechrollSpeed = techrollSpeed;
            AirDodgeSpeed = airDodge;
            RollForwardMax = rollForwardMax;
            RollBackwardMax = rollBackwardMax;
        }

        public bool Equals(FighterEvasionData other)
        {
            return 
                TechrollSpeed == other.TechrollSpeed &&
                AirDodgeSpeed == other.AirDodgeSpeed &&
                RollForwardMax == other.RollForwardMax &&
                RollBackwardMax == other.RollBackwardMax;
        }

        public FighterEvasionData Duplicate()
        {
            return new FighterEvasionData
            (
                TechrollSpeed,
                AirDodgeSpeed,
                RollForwardMax,
                RollBackwardMax
            );
        }
    }
}
