namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterRollData
    {
        public FighterActionWindow RollForward { get; set; }
        public FighterActionWindow RollBackward { get; set; }
        public int RollForwardMax { get; set; }
        public int RollBackwardMax { get; set; }
    }
}
