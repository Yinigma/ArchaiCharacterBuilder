using CleanArchitecture.Domain.ValueObjects.Fighter;

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterAirMovement
    {
        public FighterJumpData JumpData { get; set; }

        public FighterAirPhysics AirPhysics { get; set; }
        
        public int LandTime { get; set; }

        public int PratLandTime { get; set; }
    }
}
