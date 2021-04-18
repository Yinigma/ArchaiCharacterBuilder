

namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterTechData
    {
        public int TechActiveFrames { get; set; }
        public int TechRecoveryFrames { get; set; }
        public int TechrollStartupFrames { get; set; }
        public int TechrollActiveFrames { get; set; }
        public int TechrollRecoveryFrames { get; set; }
        public float TechrollSpeed { get; set; }
    }
}
