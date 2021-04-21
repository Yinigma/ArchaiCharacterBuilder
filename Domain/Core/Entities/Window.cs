using Domain.Core.Enum.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    class Window
    {
        public bool UsesCustomGravity { get; set; }
        public WindowType Type { get; set; }
        public int WindowLength { get; set; }
        public int NumberOfAnimationFrames { get; set; }
        public int AnimationStartFrame { get; set; }
        public float HorizontalSpeed { get; set; }
        public float VerticalSpeed { get; set; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
        public SpeedType HorizontalSpeedType { get; set; }
        public SpeedType VerticalSpeedType { get; set; }
        public bool HasCustomFriction { get; set; }
        public float CustomGravity { get; set; }
        public bool HasWiffLag { get; set; }
        public InvincibilityType Invincibility { get; set; }
        public int HitPauseFrame { get; set; }
        public CancelType WindowCancelType { get; set; }
        public SoundEffect SoundEffect { get; set; }
        public int SoundEffectFrame { get; set; }
        public IList<Hitbox> Children { get; private set; } = new List<Hitbox>();
    }
}