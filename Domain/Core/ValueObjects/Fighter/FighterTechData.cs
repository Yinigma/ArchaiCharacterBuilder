

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterTechData
    {
        public int TechActiveFrames { get; }
        public int TechRecoveryFrames { get; }
        public FighterActionWindow Techroll { get; }
        

        public FighterTechData(int techActive, int techRecovery, FighterActionWindow techroll, double techrollSpeed)
        {
            TechActiveFrames = techActive;
            TechRecoveryFrames = techRecovery;
            Techroll = techroll;
            //TechrollSpeed = techrollSpeed;
        }

        public bool Equals(FighterTechData other)
        {
            return TechActiveFrames == other.TechActiveFrames && TechRecoveryFrames == other.TechRecoveryFrames && Techroll.Equals(other.Techroll);// && TechrollSpeed == TechrollSpeed;
        }

        public FighterTechData Duplicate()
        {
            return new FighterTechData(TechActiveFrames, TechRecoveryFrames, Techroll.Duplicate());//, TechrollSpeed);
        }
    }
}
