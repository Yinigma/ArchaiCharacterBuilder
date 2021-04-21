namespace CleanArchitecture.Domain.ValueObjects.Fighter
{
    public class FighterJumpData
    {
        public int JumpStartTime { get; }
        public double JumpSpeed { get; }
        public double ShortHopSpeed { get; }
        public double LeaveGroundMax { get; }
        public double DoubleJumpSpeed { get; }
        public double MaxJumpHsp { get; }
        public double JumpChange { get; }
        public int MaxDoubleJumps { get; }
        public int DoubleJumpTime { get; }
        public double WalljumpHsp { get; }
        public double WalljumpVsp { get; }
        public int WalljumpTime { get; }

        public FighterJumpData
        (
            int jumpStartTime,
            double jumpSpeed,
            double shortHopSpeed,
            double leaveGroundMax,
            double doubleJumpSpeed,
            double maxJumpHsp,
            double jumpChange,
            int maxDoubleJumps,
            int doubleJumpTime,
            double walljumpHsp,
            double walljumpVsp,
            int walljumpTime
        )
        {
            JumpStartTime = jumpStartTime;
            JumpSpeed = jumpSpeed;
            ShortHopSpeed = shortHopSpeed;
            LeaveGroundMax = leaveGroundMax;
            DoubleJumpSpeed = doubleJumpSpeed;
            MaxJumpHsp = maxJumpHsp;
            JumpChange = jumpChange;
            MaxDoubleJumps = maxDoubleJumps;
            DoubleJumpTime = doubleJumpTime;
            WalljumpHsp = walljumpHsp;
            WalljumpVsp = walljumpVsp;
            WalljumpTime = walljumpTime;
        }

        public bool Equals(FighterJumpData other)
        {
            return 
                JumpStartTime == other.JumpStartTime &&
                JumpSpeed == other.JumpSpeed &&
                ShortHopSpeed == other.ShortHopSpeed &&
                LeaveGroundMax == other.LeaveGroundMax &&
                DoubleJumpSpeed == other.DoubleJumpSpeed &&
                MaxJumpHsp == other.MaxJumpHsp &&
                JumpChange == other.JumpChange &&
                MaxDoubleJumps == other.MaxDoubleJumps &&
                DoubleJumpTime == other.DoubleJumpTime &&
                WalljumpHsp == other.WalljumpHsp &&
                WalljumpVsp == other.WalljumpVsp &&
                WalljumpTime == other.WalljumpTime;
        }

        public FighterJumpData Duplicate()
        {
            return new FighterJumpData
            (
                JumpStartTime,
                JumpSpeed,
                ShortHopSpeed,
                LeaveGroundMax,
                DoubleJumpSpeed,
                MaxJumpHsp,
                JumpChange,
                MaxDoubleJumps,
                DoubleJumpTime,
                WalljumpHsp,
                WalljumpVsp,
                WalljumpTime
            );
        }
    }
}
