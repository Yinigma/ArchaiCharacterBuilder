using Archai.CharacterCreator.Domain.Enumeration.Hitbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class HitboxKnockback
    {
        public Angle KnockbackDirection { get; }
        public double BaseKnockback { get; }
        public double KnockbackScaling { get; }
        public int EndOfLifetimeKnockback { get; }
        public AngleBehavior AngleBehavior { get; }

        public HitboxKnockback(Angle direction, double baseKnockback, double knockbackScaling, int eolKnockback, AngleBehavior angleBehavior)
        {
            KnockbackDirection = direction;
            BaseKnockback = baseKnockback;
            KnockbackScaling = knockbackScaling;
            EndOfLifetimeKnockback = eolKnockback;
            AngleBehavior = angleBehavior;
        }

        public override bool Equals(object other)
        {
            return other is HitboxKnockback && AngleBehavior == (other as HitboxKnockback).AngleBehavior && BaseKnockback == (other as HitboxKnockback).BaseKnockback && KnockbackScaling == (other as HitboxKnockback).KnockbackScaling && EndOfLifetimeKnockback == (other as HitboxKnockback).EndOfLifetimeKnockback && AngleBehavior == (other as HitboxKnockback).AngleBehavior;
        }

        public override int GetHashCode()
        {
            return (KnockbackDirection, BaseKnockback, KnockbackScaling, EndOfLifetimeKnockback, AngleBehavior).GetHashCode();
        }
    }
}
