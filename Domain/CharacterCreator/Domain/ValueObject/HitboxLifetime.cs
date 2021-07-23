using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
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

        public override bool Equals(object other)
        {
            return other is HitboxLifetime && StartFrame == (other as HitboxLifetime).StartFrame && Lifetime == (other as HitboxLifetime).Lifetime && HitLockoutDuration == (other as HitboxLifetime).HitLockoutDuration;
        }

        public override int GetHashCode()
        {
            return (StartFrame, Lifetime, HitLockoutDuration).GetHashCode();
        }
    }
}
