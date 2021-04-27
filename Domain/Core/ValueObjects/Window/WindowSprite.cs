using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Window
{
    public class WindowSprite
    {
        //Animation
        public int NumberOfAnimationFrames { get; }
        public int AnimationStartFrame { get; }
        public int HitPauseFrame { get; }
    }
}
