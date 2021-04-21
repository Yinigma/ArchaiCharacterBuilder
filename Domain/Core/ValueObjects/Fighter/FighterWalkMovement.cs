using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterWalkMovement
    {
        public double WalkSpeed { get; }
        public double WalkAccel { get; }
        public int WalkTurnTime { get; }

        public FighterWalkMovement(double walkSpeed, double walkAccel, int walkTurnTime)
        {
            WalkSpeed = walkSpeed;
            WalkAccel = walkAccel;
            WalkTurnTime = walkTurnTime;
        }

        public bool Equals(FighterWalkMovement other)
        {
            return other.WalkAccel == WalkAccel && other.WalkSpeed == WalkSpeed && other.WalkTurnTime == WalkTurnTime;
        }

        public FighterWalkMovement Duplicate()
        {
            return new FighterWalkMovement(WalkSpeed, WalkAccel, WalkTurnTime);
        }
    }
}
