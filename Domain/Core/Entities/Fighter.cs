using Domain.Core.ValueObjects.Fighter;
using Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class Fighter
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public float KnockbackAdjustment { get; set; }

        public FighterHurtboxData FighterHurtboxData { get; set; }

        public FighterGroundMovement GroundMovement { get; set; }

        public FighterAirMovement AirMovement { get; set; }

        public FighterEvasionData EvasionData { get; set; }

        public Point BubbleOffset { get; set; }

        public ISet<Attack> Attacks { get; private set; } = new Set<Attack>();

        public IDictionary<string, object> Parameters { get; private set; } = new Dictionary<string, object>();

        public IList<ColorProfile> ColorPalette { get; private set; } = new List<ColorProfile>();

        public FighterSounds SoundData { get; set; }
    }
}
