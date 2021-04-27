using Domain.Core.Enum.Attack;
using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Attack
{
    public class AttackConfiguration
    {
        //public long Id { get; set; }
        //public string AttackName { get; set; }
        //public string Description { get; set; }
        //public Sprite AttackSprite { get; set; }
        public AttackType AttackType { get; }
        public GroundingCategory Groundedness { get; }
        public bool HasLandingLag { get; }
        public bool OffLedge { get; }
        public bool CustomGravity { get; }
        public Sprite Hurtbox { get; }
        

        public AttackConfiguration(AttackType type, GroundingCategory groundedness, bool hasLandingLag, bool offLedge, bool customGrav, Sprite hurtbox)
        {
            AttackType = type;
            Groundedness = groundedness;
            HasLandingLag = hasLandingLag;
            OffLedge = offLedge;
            CustomGravity = customGrav;
            Hurtbox = hurtbox;
        }

        public bool Equals(AttackConfiguration other)
        {
            return AttackType == other.AttackType && Groundedness == other.Groundedness && HasLandingLag == other.HasLandingLag && OffLedge == other.OffLedge && CustomGravity == other.CustomGravity && Hurtbox.Equals(other.Hurtbox);
        }

        public AttackConfiguration Duplicate()
        {
            return new AttackConfiguration(AttackType, Groundedness, HasLandingLag, OffLedge, CustomGravity, Hurtbox);
        }
    }
}
