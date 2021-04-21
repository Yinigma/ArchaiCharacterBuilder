using Domain.Core.Entities;
using Domain.Core.ValueObjects;

namespace Domain.Application.CharacterCreator.Data
{
    class ProjectFighter : FighterConfiguration, IProjectItem
    {
        private const string IDLE_HURTBOX_NAME = "Idle Hurtbox";
        private const string CROUCH_HURTBOX_NAME = "Crouch Hurtbox";

        public IProjectItem Duplicate()
        {
            ProjectFighter dupFighter = new ProjectFighter();
            dupFighter.AirAccel = AirAccel;
            dupFighter.AirDodge = AirDodge;
            dupFighter.AirDodgeSound = new SoundEffect(AirDodgeSound.Path);
            dupFighter.AirDodgeSpeed = AirDodgeSpeed;
            dupFighter.AirFriction = AirFriction;
            dupFighter.AirHurtbox = AirHurtbox;
            dupFighter.AirMaxSpeed = AirMaxSpeed;
            dupFighter.Attacks;
            dupFighter.BubbleOffset = BubbleOffset;
            foreach(ColorProfile profile in ColorPalette)
            {
                ColorProfile dupProfile = new ColorProfile();
                foreach(ColorRow row in profile.ColorRows)
                {
                    ColorRow dupRow = new ColorRow(row.BaseColors, row.HueTolerance, row.SaturationTolerance, row.ValueTolerance);
                    dupProfile.ColorRows.Add(dupRow);
                }
                dupFighter.ColorPalette.Add(dupProfile);
            }
            dupFighter.Crouch = dupFighter.Crouch.Duplicate();
            dupFighter.CrouchHurtbox.Id = 
            
        }
    }
}
