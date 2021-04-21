namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterDashMovement
    {
        //Dash movement vars
        public int InitialDashTime { get; }
        public int InitialDashSpeed { get; }
        public double DashSpeed { get; }
        public int DashTurnTime { get; }
        public double DashTurnAccel { get; }
        public double DashStopTime { get; }
        public double DashStopPercent { get; }

        public FighterDashMovement(int initialDashTime, int initialDashSpeed, double dashSpeed, int dashTurnTime, double dashTurnAccel, double dashStopTime, double dashStopPercent)
        {
            InitialDashTime = initialDashTime;
            InitialDashSpeed = initialDashSpeed;
            DashSpeed = dashSpeed;
            DashTurnTime = dashTurnTime;
            DashTurnAccel = dashTurnAccel;
            DashStopTime = dashStopTime;
            DashStopPercent = dashStopPercent;
        }

        public bool Equals(FighterDashMovement other)
        {
            return
                InitialDashTime == other.InitialDashTime &&
                InitialDashSpeed == other.InitialDashSpeed &&
                DashSpeed == other.DashSpeed &&
                DashTurnTime == other.DashTurnTime &&
                DashTurnAccel == other.DashTurnAccel &&
                DashStopTime == other.DashStopTime &&
                DashStopPercent == other.DashStopPercent;
        }

        public FighterDashMovement Duplicate()
        {
            return new FighterDashMovement
            (
                InitialDashTime,
                InitialDashSpeed,
                DashSpeed,
                DashTurnTime,
                DashTurnAccel,
                DashStopTime,
                DashStopPercent
            );
        }
    }
}
