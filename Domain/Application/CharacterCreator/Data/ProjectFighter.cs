using Domain.Core.Entities;
using Domain.Core.ValueObjects;
using Domain.Core.ValueObjects.Fighter;
using System.Collections.Generic;

namespace Domain.Application.CharacterCreator.Data
{
    class ProjectFighter: IProjectItem
    {
        private const string IDLE_HURTBOX_NAME = "Idle Hurtbox";
        private const string CROUCH_HURTBOX_NAME = "Crouch Hurtbox";

        public long Id { get; }
        public string Name { get; }
        public FighterConfiguration Configuration { get; set; }
        public ColorProfile ColorProfile { get; set; }
        public Vector2 BubbleOffset { get; set; }

        private IList<ProjectAttack> attacks;

        private ProjectFighter(long id, string name, FighterConfiguration config, ColorProfile colProfile, Vector2 offset)
        {
            Id = id;
            Name = name;
            Configuration = config;
            ColorProfile = colProfile;
            BubbleOffset = offset;
        }

        public static ProjectFighter CreateNew(long id, string name)
        {
            return new ProjectFighter
            (
                id,
                name,
                new FighterConfiguration
                (
                    1.0, 
                    new FighterHurtboxData(),
                    new FighterGroundMovement
                    (
                        new FighterWalkMovement
                        (
                            3.75,
                            3.5,
                            6
                        ),
                        new FighterDashMovement
                        (
                            12,
                            8,
                            7.125,
                            14,
                            1,
                            5,
                            .375
                        ),
                        new FighterWaveDashMovement
                        (
                            8,
                            1.35,
                            0.075
                        ),
                        0.65,
                        1.3
                    ),
                    new FighterAirMovement
                    (
                        new FighterJump
                        (
                            5,
                            9.8,
                            5.7,
                            6,
                            10,
                            6,
                            3,
                            1,
                            4,
                            15,
                            5.5,
                            8.5,
                            25
                        ),
                        new FighterAirPhysics
                        (
                            0.3,
                            0.95,
                            0.045,
                            9.5,
                            5,
                            13.5,
                            0.45,
                            0.4875
                        ),
                        5,
                        14
                    ),
                    new FighterEvasionData
                    (
                        10,
                        7.75,
                        10,
                        10
                    )
                ),
                new ColorProfile
                (
                    new string[]{"default"}, 
                    new ColorTolerance[] 
                    { 
                        new ColorTolerance
                        (
                            new Angle(10), 
                            new UnsignedPortion(0.1), 
                            new UnsignedPortion(0.1)
                        )
                    }, 
                    new Color[1][] { new Color[]{ Color.White } }
                ),
                new Vector2(0,0)
            );
        }

        public IProjectItem Duplicate(long id)
        {
            return new ProjectFighter(id, Name, Configuration, ColorProfile, BubbleOffset);
        }

        public bool Equals(ProjectFighter other)
        {
            return Id == other.Id;
        }
    }
}
