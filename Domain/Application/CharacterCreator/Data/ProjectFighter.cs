using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Application.CharacterCreator.Data
{
    class ProjectFighter : IProjectItem
    {
        public long Id { get; }

        public string Name { get; set; }

        //Walk movement vars
        public float WalkSpeed { get; private set; }
        public float WalkAcceleration { get; private set; }
        public int WalkTurnTime { get; private set; }

        //public FighterDashMovement DashMovement { get; private set; }

        //Ground friction
        public float GroundFriction { get; private set; }
        public float MoonwalkAccel { get; private set; }

        //Wavedash junk
        public int WaveLandTime { get; private set; }
        public float WaveLandAdj { get; private set; }
        public float WaveFriction { get; private set; }

        public Fighter(long id)
        {
            Id = id;
        }

        public void UpdateWalk(float walkSpeed, float walkAcceleration, int walkTurnTime)
        {
            WalkSpeed = walkSpeed;
            WalkAcceleration = walkAcceleration;
            WalkTurnTime = walkTurnTime;
        }

        public IProjectItem Duplicate()
        {

        }
    }
}
