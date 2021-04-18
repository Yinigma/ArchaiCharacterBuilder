namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterDashMovement
    {
        //Dash movement vars
        public int InitialDashTime { get; set; }
        public int InitialDashSpeed { get; set; }
        public float DashSpeed { get; set; }
        public int DashTurnTime { get; set; }
        public float DashTurnAccel { get; set; }
        public float DashStopTime { get; set; }
        public float DashStopPercent { get; set; }
    }
}
