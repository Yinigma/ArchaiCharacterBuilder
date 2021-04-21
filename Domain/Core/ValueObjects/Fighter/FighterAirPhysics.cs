namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterAirPhysics
    {
        public double AirAcceleration { get; }
        public double PratFallAcceleration { get; }
        public double AirFriction { get; }
        public double MaxFallSpeed { get; }
        public double MaxAirSpeed { get; }
        public double FastFallSpeed { get; }
        public double GravitySpeed { get; }
        public double HitstunGravity { get; }

        public FighterAirPhysics(double airAccel, double pratAccel, double airFriction, double maxFallSpeed, double maxAirSpeed, double fastFallSpeed, double gravitySpeed, double hitstunGravity)
        {
            AirAcceleration = airAccel;
            PratFallAcceleration = pratAccel;
            AirFriction = airFriction;
            MaxFallSpeed = maxFallSpeed;
            MaxAirSpeed = maxAirSpeed;
            FastFallSpeed = fastFallSpeed;
            GravitySpeed = gravitySpeed;
            HitstunGravity = hitstunGravity;
        }

        public bool Equals(FighterAirPhysics other)
        {
            return 
                AirAcceleration == other.AirAcceleration &&
                PratFallAcceleration == other.PratFallAcceleration &&
                AirFriction == other.AirFriction &&
                MaxFallSpeed == other.MaxFallSpeed &&
                MaxAirSpeed == other.MaxAirSpeed &&
                FastFallSpeed == other.FastFallSpeed &&
                GravitySpeed == other.GravitySpeed && 
                HitstunGravity == other.HitstunGravity;
        }

        public FighterAirPhysics Duplicate()
        {
            return new FighterAirPhysics
            (
                AirAcceleration,
                PratFallAcceleration,
                AirFriction,
                MaxFallSpeed,
                MaxAirSpeed,
                FastFallSpeed,
                GravitySpeed,
                HitstunGravity
            );
        }
    }
}
