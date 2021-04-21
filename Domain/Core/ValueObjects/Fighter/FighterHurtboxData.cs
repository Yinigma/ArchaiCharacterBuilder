namespace Domain.Core.ValueObjects.Fighter
{
    public class FighterHurtboxData
    {
        public int FighterHeight { get; set; }
        public Sprite HurtboxSpriteIndex { get; set; }
        public Sprite AirHurtboxSpriteIndex { get; set; }
        public Sprite CrouchHurtboxSpriteIndex { get; set; }
        public Sprite HitstunHurtboxSpriteIndex { get; set; }
    }
}
