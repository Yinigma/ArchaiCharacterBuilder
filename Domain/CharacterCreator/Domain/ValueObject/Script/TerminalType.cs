using Archai.CharacterCreator.Domain.Entity;
using Archai.CharacterCreator.Domain.Enumeration.Script;
using Domain.Core.Entities;
using System;

namespace Archai.CharacterCreator.Domain.ValueObject.Script
{
    public sealed class TerminalType : IScriptVariableType
    {
        public PrimaryType PrimaryType { get; }

        public TerminalType(PrimaryType type)
        {
            PrimaryType = type;
        }

        public bool Assignable(Type valueType)
        {
            switch(PrimaryType)
            {
                case PrimaryType.BOOLEAN:
                    return valueType == typeof(bool);
                case PrimaryType.INTEGER:
                    return valueType == typeof(int) || valueType == typeof(long);
                case PrimaryType.REAL:
                    return valueType == typeof(double) || valueType == typeof(float);
                case PrimaryType.STRING:
                    return valueType == typeof(string);
                case PrimaryType.HITBOX:
                    return valueType == typeof(Hitbox);
                case PrimaryType.HURTBOX:
                    return valueType == typeof(Hurtbox) || valueType == typeof(HurtboxSequence);
                //case PrimaryType.HIT_EFFECT:
                //return valueType == typeof(HitEffect);
                case PrimaryType.FIGHTER:
                    return valueType == typeof(Fighter);

            }

        }

        public bool Equals(IScriptVariableType other)
        {
            return other is TerminalType && PrimaryType == (other as TerminalType).PrimaryType;
        }
    }
}
