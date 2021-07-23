using Archai.CharacterCreator.Domain.Enumeration.Hitbox;

namespace Archai.CharacterCreator.Domain.ValueObject
{
    public class HitboxShape
    {
        public Vector2 Position { get; }
        public Vector2 Size { get; }
        public HitboxShapeType ShapeType { get; }

        public HitboxShape(Vector2 position, Vector2 size, HitboxShapeType type)
        {
            Position = position;
            Size = size;
            ShapeType = type;
        }

        public override bool Equals(object other)
        {
            return other is HitboxShape && Position.Equals((other as HitboxShape).Position) && Size.Equals((other as HitboxShape).Size) && ShapeType == (other as HitboxShape).ShapeType;
        }

        public override int GetHashCode()
        {
            return (Position, Size, ShapeType).GetHashCode();
        }
    }
}
