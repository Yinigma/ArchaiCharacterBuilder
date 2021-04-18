namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterGroundMovement
    {
        //Ground movement
        //Walk movement vars
        public float WalkSpeed { get; private set; }
        public float WalkAccel { get; private set; }
        public int WalkTurnTime { get; private set; }

        public FighterDashMovement DashMovement { get; private set; }

        //Ground friction
        public float GroundFriction { get; private set; }
        public float MoonwalkAccel { get; private set; }

        //Wavedash junk
        public int WaveLandTime { get; set; }
        public float WaveLandAdj { get; set; }
        public float WaveFriction { get; set; }
    }
}
