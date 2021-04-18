namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterAirPhysics
    {
        public float AirAccel { get; set; }
        public float PratFallAccel { get; set; }
        public float AirFriction { get; set; }
        public float MaxFall { get; set; }
        public float AirMaxSpeed { get; set; }
        public float FastFall { get; set; }
        public float GravitySpeed { get; set; }
        public float HitstunGravity { get; set; }
    }
}
