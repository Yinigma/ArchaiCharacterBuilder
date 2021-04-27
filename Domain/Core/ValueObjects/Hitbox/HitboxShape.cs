using Domain.Core.Enum.Hitbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.ValueObjects.Hitbox
{
    public class HitboxShape
    {
        public Vector2 Position { get; }
        public Vector2 Size { get; }
        public HitboxShapeType Shape { get; }

        public HitboxShape(Vector2 position, Vector2 size, HitboxShapeType type)
        {
            Position = position;
            Size = size;
            Shape = type;
        }

        public bool Equals(HitboxShape other)
        {
            return Position.Equals(other.Position) && Size.Equals(other.Size) && Shape == other.Shape;
        }

        public HitboxShape Duplicate()
        {
            return new HitboxShape(Position, Size, Shape);
        }
    }
}
