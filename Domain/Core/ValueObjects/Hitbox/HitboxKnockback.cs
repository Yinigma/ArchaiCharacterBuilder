using Domain.Core.Enum.Hitbox;

namespace Domain.Core.ValueObjects.Hitbox
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

        public bool Equals(HitboxKnockback other)
        {
            return AngleBehavior == other.AngleBehavior && BaseKnockback == other.BaseKnockback && KnockbackScaling == other.KnockbackScaling && EndOfLifetimeKnockback == other.EndOfLifetimeKnockback && AngleBehavior == other.AngleBehavior;
        }

        public HitboxKnockback Duplicate()
        {
            return new HitboxKnockback(KnockbackDirection, BaseKnockback, KnockbackScaling, EndOfLifetimeKnockback, AngleBehavior);
        }
    }
}
