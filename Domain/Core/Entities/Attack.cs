using Domain.Core.Enum.Attack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Entities
{
    public abstract class Attack
    {
        public long Id { get; set; }
        public string AttackName { get; internal set; }
        public string Description { get; set; }
        public AttackType AttackType { get; set; }
        public GroundCategory Category { get; set; }
        public bool HasLandingLag { get; set; }
        public bool OffLedge { get; set; }
        public bool CustomGravity { get; set; }
        public Sprite AttackSprite { get; set; }
        public Sprite Hurtbox { get; set; }
    }
}
