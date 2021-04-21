namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterBaseSoundConfiguration
    {
        public SoundEffect LandSound { get; }
        public SoundEffect WavelandSound { get; }
        public SoundEffect JumpSound { get; }
        public SoundEffect DoubleJumpSound { get; }
        public SoundEffect AirDodgeSound { get; }
        public SoundEffect LandingLagSound { get; }

        public FighterBaseSoundConfiguration(SoundEffect land, SoundEffect waveLand, SoundEffect jump, SoundEffect dubJump, SoundEffect airDodge, SoundEffect landLag)
        {
            LandSound = land;
            WavelandSound = waveLand;
            JumpSound = jump;
            DoubleJumpSound = dubJump;
            AirDodgeSound = airDodge;
            LandingLagSound = landLag;
        }

        public bool Equals(FighterBaseSoundConfiguration other)
        {
            return other.LandSound
        }

        public FighterBaseSoundConfiguration Duplicate()
        {
            return new FighterBaseSoundConfiguration(LandSound, WavelandSound, JumpSound, DoubleJumpSound, AirDodgeSound, LandingLagSound);
        }
    }
}
