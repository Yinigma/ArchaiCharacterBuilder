namespace CleanArchitecture.Domain.ValueObjects.Fighter
{
    public class FighterJumpData
    {
        public int JumpStartTime { get; set; }
        public float JumpSpeed { get; set; }
        public float ShortHopSpeed { get; set; }
        public float LeaveGroundMax { get; set; }
        public float DoubleJumpSpeed { get; set; }
        public float MaxJumpHsp { get; set; }
        public float JumpChange { get; set; }
        public int MaxDoubleJumps { get; set; }
        public int DoubleJumpTime { get; set; }
        public float WalljumpHsp { get; set; }
        public float WalljumpVsp { get; set; }
        public int WalljumpTime { get; set; }
    }
}
