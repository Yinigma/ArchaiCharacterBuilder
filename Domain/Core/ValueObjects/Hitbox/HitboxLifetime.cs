using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Hitbox
{
    public class HitboxLifetime
    {
        public int StartFrame { get; }
        public int Lifetime { get; }
        public int HitLockoutDuration { get; }

        public HitboxLifetime(int startFrame, int lifetime, int hitLockoutDuration)
        {
            StartFrame = startFrame;
            Lifetime = lifetime;
            HitLockoutDuration = hitLockoutDuration;
        }

        public bool Equals(HitboxLifetime other)
        {
            return StartFrame == other.StartFrame && Lifetime == other.Lifetime && HitLockoutDuration == other.HitLockoutDuration;
        }

    }
}
