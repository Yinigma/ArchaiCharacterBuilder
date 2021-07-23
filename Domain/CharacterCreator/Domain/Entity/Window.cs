using Archai.CharacterCreator.Domain.Enumeration.Window;
using Archai.CharacterCreator.Domain.ValueObject;
using CharacterCreator.Domain.Project;

namespace CharacterCreator.Domain.Project
{
    public class Window
	{
		LayerGroup rootLayer;
		public WindowType Type { get; }
		public int WindowLength { get; }
		public bool HasWiffLag { get; }
		public InvincibilityType Invincibility { get; }
		public CancelType Cancel { get; }
		public Vector2 Speed { get; }
		public SpeedType HorizontalSpeedType { get; }
		public SpeedType VerticalSpeedType { get; }
		public bool HasCustomFriction { get; }
		public bool UsesCustomGravity { get; }
		public double CustomGravity { get; }

		//animation data
		public int NumberOfAnimationFrames { get; }
		public int AnimationStartFrame { get; }
		public int HitPauseFrame { get; }

		//sounds
		public SoundEffect SoundEffect { get; }
		public int SoundEffectFrame { get; }
	}
}

