using Domain.Core.Enum.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Window
{
    public class WindowMovement
    {
        //Movement
        public Vector2 Speed { get; }
        public SpeedType HorizontalSpeedType { get; }
        public SpeedType VerticalSpeedType { get; }
        public bool HasCustomFriction { get; }
        public double? CustomGravity { get; }

        public WindowMovement(Vector2 speed, SpeedType horizontal, SpeedType vertical, bool hasCustomFriction, double? gravity)
        {
            Speed = speed;
            HorizontalSpeedType = horizontal;
            VerticalSpeedType = vertical;
            HasCustomFriction = hasCustomFriction;
            CustomGravity = gravity;
        }

        public bool Equals(WindowMovement other)
        {
            return Speed.Equals(other.Speed) && HorizontalSpeedType == other.HorizontalSpeedType && VerticalSpeedType == other.VerticalSpeedType && HasCustomFriction == other.HasCustomFriction && CustomGravity == other.CustomGravity;
        }

        public WindowMovement Duplicate()
        {
            return new WindowMovement(Speed, HorizontalSpeedType, VerticalSpeedType, HasCustomFriction, CustomGravity);
        }
    }
}
