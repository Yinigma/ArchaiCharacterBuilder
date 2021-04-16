using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCase.SetFighterWalkMovement
{
    public sealed class FighterMovementUpdate
    {
        public long ProjectId { get; private set; }
        public long FighterId { get; private set; }
        //Walk movement vars
        public float WalkSpeed { get; private set; }
        public float WalkAccel { get; private set; }
        public int WalkTurnTime { get; private set; }
    }
}
