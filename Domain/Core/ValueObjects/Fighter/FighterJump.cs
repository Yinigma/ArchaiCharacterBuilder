namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterJump
    {
        public int JumpStartTime { get; }
        public double JumpSpeed { get; }
        public double ShortHopSpeed { get; }
        public double LeaveGroundMax { get; }
        public double DoubleJumpSpeed { get; }
        public double MaxJumpHsp { get; }
        public double JumpChange { get; }
        public int MaxDoubleJumps { get; }
        public int DoubleJumpStartTime { get; }
        public int DoubleJumpEndTime { get; }
        public double WalljumpHsp { get; }
        public double WalljumpVsp { get; }
        public int WalljumpTime { get; }

        public FighterJump
        (
            int jumpStartTime,
            double jumpSpeed,
            double shortHopSpeed,
            double leaveGroundMax,
            double doubleJumpSpeed,
            double maxJumpHsp,
            double jumpChange,
            int maxDoubleJumps,
            int doubleJumpStartTime,
            int doubleJumpEndTime,
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
            DoubleJumpStartTime = doubleJumpStartTime;
            DoubleJumpEndTime = doubleJumpEndTime;
            WalljumpHsp = walljumpHsp;
            WalljumpVsp = walljumpVsp;
            WalljumpTime = walljumpTime;
        }

        public bool Equals(FighterJump other)
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
                DoubleJumpStartTime == other.DoubleJumpStartTime &&
                DoubleJumpEndTime == other.DoubleJumpEndTime &&
                WalljumpHsp == other.WalljumpHsp &&
                WalljumpVsp == other.WalljumpVsp &&
                WalljumpTime == other.WalljumpTime;
        }

        public FighterJump Duplicate()
        {
            return new FighterJump
            (
                JumpStartTime,
                JumpSpeed,
                ShortHopSpeed,
                LeaveGroundMax,
                DoubleJumpSpeed,
                MaxJumpHsp,
                JumpChange,
                MaxDoubleJumps,
                DoubleJumpStartTime,
                DoubleJumpEndTime,
                WalljumpHsp,
                WalljumpVsp,
                WalljumpTime
            );
        }
    }
}
