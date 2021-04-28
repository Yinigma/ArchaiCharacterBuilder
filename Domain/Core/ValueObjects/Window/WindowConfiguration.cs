using Domain.Core.Enum.Window;
using Domain.Core.ValueObjects;
using Domain.Core.ValueObjects.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Window
{
    public class WindowConfiguration
    {
        public WindowTiming Timing { get; }
        public WindowMovement Movement { get; }
        public InvincibilityType Invincibility { get; }
        public CancelType Cancel { get; }

        public WindowConfiguration(WindowTiming timing, WindowMovement movement, InvincibilityType invincibility, CancelType cancel)
        {
            Timing = timing;
            Movement = movement;
            Invincibility = invincibility;
            Cancel = cancel;
        }

        public bool Equals(WindowConfiguration other)
        {
            return Timing.Equals(other.Timing) && Movement.Equals(other.Movement) && Invincibility == other.Invincibility && Cancel == other.Cancel;
        }

        public WindowConfiguration Duplicate()
        {
            return new WindowConfiguration(Timing, Movement, Invincibility, Cancel);
        }

        
        //public IList<Hitbox> Children { get; private set; } = new List<Hitbox>();
    }
}