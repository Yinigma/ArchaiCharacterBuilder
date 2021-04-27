namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterRollData
    {
        public FighterActionWindow RollForward { get; }
        public FighterActionWindow RollBackward { get; }
        public int RollForwardMax { get; }
        public int RollBackwardMax { get; }

        public FighterRollData(FighterActionWindow rollForward, FighterActionWindow rollBackward, int forwardMax, int backMax)
        {
            RollForward = rollForward;
            RollBackward = rollBackward;
            RollForwardMax = forwardMax;
            RollBackwardMax = backMax;
        }

        public bool Equals(FighterRollData other)
        {
            return RollForward.Equals(other.RollForward) && RollBackward.Equals(other.RollBackward) && RollForwardMax == other.RollForwardMax && RollBackwardMax == other.RollBackwardMax;
        }

        public FighterRollData Duplicate()
        {
            return new FighterRollData(RollForward.Duplicate(), RollBackward.Duplicate(), RollForwardMax, RollBackwardMax);
        }
    }
}
