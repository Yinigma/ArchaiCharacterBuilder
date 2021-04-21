namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterActionWindow
    {
        public int StartupFrames { get; }
        public int ActiveFrames { get; }
        public int RecoveryFrames { get; }

        public FighterActionWindow(int startup, int active, int recovery)
        {
            StartupFrames = startup;
            ActiveFrames = active;
            RecoveryFrames = recovery;
        }

        public bool Equals(FighterActionWindow other)
        {
            return StartupFrames == other.StartupFrames && ActiveFrames == other.ActiveFrames && RecoveryFrames == other.RecoveryFrames;
        }

        public FighterActionWindow Duplicate()
        {
            return new FighterActionWindow(StartupFrames, ActiveFrames, RecoveryFrames);
        }
    }
}
