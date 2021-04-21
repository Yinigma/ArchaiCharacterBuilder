using CleanArchitecture.Domain.ValueObjects.Fighter;

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterAirMovement
    {
        public FighterJumpData JumpData { get; }
        public FighterAirPhysics AirPhysics { get; }
        public int LandTime { get; }
        public int PratLandTime { get; }

        public FighterAirMovement(FighterJumpData jumpData, FighterAirPhysics airPhysics, int landTime, int pratLandTime)
        {
            JumpData = jumpData;
            AirPhysics = airPhysics;
            LandTime = landTime;
            PratLandTime = pratLandTime;
        }

        public bool Equals(FighterAirMovement other)
        {
            return AirPhysics.Equals(other.AirPhysics) && JumpData.Equals(other.JumpData) && LandTime == other.LandTime && PratLandTime == other.PratLandTime;
        }

        public FighterAirMovement Duplicate()
        {
            return new FighterAirMovement(JumpData.Duplicate(), AirPhysics.Duplicate(), LandTime, PratLandTime);
        }
    }
}
