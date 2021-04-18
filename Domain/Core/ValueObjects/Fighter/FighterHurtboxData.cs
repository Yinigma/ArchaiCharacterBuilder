namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterHurtboxData
    {
        public uint FighterHeight { get; set; }
        public int HurtboxSpriteIndex { get; set; }
        public int AirHurtboxSpriteIndex { get; set; }
        public int CrouchHurtboxSpriteIndex { get; set; }
        public int HitstunHurtboxSpriteIndex { get; set; }
    }
}
