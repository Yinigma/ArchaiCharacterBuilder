namespace Archai.CharacterCreator.Domain.ValueObject

{
    public class ActionWindow
    {
        public int StartupFrames { get; }
        public int ActiveFrames { get; }
        public int RecoveryFrames { get; }

        public ActionWindow(int startup, int active, int recovery)
        {
            StartupFrames = startup;
            ActiveFrames = active;
            RecoveryFrames = recovery;
        }

        public bool Equals(ActionWindow other)
        {
            return StartupFrames == other.StartupFrames && ActiveFrames == other.ActiveFrames && RecoveryFrames == other.RecoveryFrames;
        }
    }
}
