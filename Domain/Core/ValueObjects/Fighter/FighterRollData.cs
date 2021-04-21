namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterRollData
    {
        public FighterActionWindow RollForward { get; set; }
        public FighterActionWindow RollBackward { get; set; }
        public int RollForwardMax { get; set; }
        public int RollBackwardMax { get; set; }

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
