namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterGroundMovement
    {
        public FighterWalkMovement WalkMovement { get; }
        public FighterDashMovement DashMovement { get; }
        public double GroundFriction { get; }
        public double MoonwalkAccel { get; }
        public FighterWaveDashMovement WavedashMovement { get; }

        public FighterGroundMovement(FighterWalkMovement walk, FighterDashMovement dash, FighterWaveDashMovement wavedash, double groundFriction, double moonWalkAccel)
        {
            WalkMovement = walk;
            DashMovement = dash;
            WavedashMovement = wavedash;
            GroundFriction = groundFriction;
            MoonwalkAccel = moonWalkAccel;
        }

        public bool Equals(FighterGroundMovement other)
        {
            return
                WalkMovement.Equals(other.WalkMovement) &&
                DashMovement.Equals(other.DashMovement) &&
                WavedashMovement.Equals(other.WavedashMovement) &&
                GroundFriction == other.GroundFriction &&
                MoonwalkAccel == other.MoonwalkAccel;
        }

        public FighterGroundMovement Duplicate()
        {
            return new FighterGroundMovement
            (
                WalkMovement.Duplicate(),
                DashMovement.Duplicate(),
                WavedashMovement.Duplicate(),
                GroundFriction,
                MoonwalkAccel
            );
        }
    }
}
