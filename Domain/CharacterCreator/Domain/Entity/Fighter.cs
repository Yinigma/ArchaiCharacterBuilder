using Archai.CharacterCreator.Domain.Enumeration;
using Archai.CharacterCreator.Domain.ValueObject;
using Archai.CharacterCreator.Domain.ValueObject.Script;
using CharacterCreator.Domain.Project;
using System;
using System.Collections.Generic;

namespace Archai.CharacterCreator.Domain.Entity
{
    public class Fighter : IProjectItem
    {
        public string Name { get; set; }

        public Properties FighterProperties { get; private set; } = new Properties();

        //Skinning
        public Sprite Portrait { get; set; }
        public Sprite VictoryScreen { get; set; }
        public Sprite MenuIcon { get; set; }
        public Sprite OffScreenIcon { get; set; }
        public Dictionary<FighterActionSprite, SpriteSequence> actionAnimations = new Dictionary<FighterActionSprite, SpriteSequence>();

        public void SetActionAnimation(FighterActionSprite slot, SpriteSequence sequence)
        {
            actionAnimations[slot] = sequence;
        }

        public ColorProfile ColorProfile { get; set; }
        public Vector2 BubbleOffset { get; set; }

        public ISet<Attack> Attacks { get; } = new HashSet<Attack>();
        public void AddAttack(Attack atk)
        {
            Attacks.Add(atk);
        }

        public void RemoveAttack(Attack atk)
        {
            Attacks.Remove(atk);
        }

        private IDictionary<FighterScriptSlot, IList<IScript>> scripts = new Dictionary<FighterScriptSlot, IList<IScript>>();

        internal void AppendScript(IScript script, FighterScriptSlot slot)
        {
            scripts[slot].Add(script);
        }

        internal void InsertScript(IScript script, int index, FighterScriptSlot slot)
        {
            scripts[slot].Insert(index, script);
        }

        private IList<FighterTemplate> templates = new List<FighterTemplate>();

        public void InsertTemplate(FighterTemplate template, int index)
        {
            if(!templates.Contains(template))
            {
                templates.Insert(index, template);
            }
            //TODO: Figure out how to resolve and update name conflicts
        }
        
        public Article Article1 { get; set; }
        public Article Article2 { get; set; }
        public Article Article3 { get; set; }
        public Article SolidArticle{ get; set; }
        public Article PlatformArticle { get; set; }

        public float KnockbackAdjustment { get; set; }
        //Hurtbox Data
        public int FighterHeight { get; set; }
        public Hurtbox HurtboxSpriteIndex { get; set; }
        public Hurtbox AirHurtboxSpriteIndex { get; set; }
        public Hurtbox CrouchHurtboxSpriteIndex { get; set; }
        public Hurtbox HitstunHurtboxSpriteIndex { get; set; }
        //Movement
        public double WalkSpeed { get; set; }
        public double WalkAccel { get; set; }
        public int WalkTurnTime { get; set; }
        public int InitialDashTime { get; set; }
        public int InitialDashSpeed { get; set; }
        public double DashSpeed { get; set; }
        public int DashTurnTime { get; set; }
        public double DashTurnAccel { get; set; }
        public double DashStopTime { get; set; }
        public double DashStopPercent { get; set; }
        public double GroundFriction { get; set; }
        public double MoonwalkAccel { get; set; }
        public int WaveLandTime { get; set; }
        public double WaveLandAdj { get; set; }
        public double WaveFriction { get; set; }
        //Jump
        public int JumpStartTime { get; set; }
        public double JumpSpeed { get; set; }
        public double ShortHopSpeed { get; set; }
        public double LeaveGroundMax { get; set; }
        public double DoubleJumpSpeed { get; set; }
        public double MaxJumpHsp { get; set; }
        public double JumpChange { get; set; }
        public int MaxDoubleJumps { get; set; }
        public int DoubleJumpStartTime { get; set; }
        public int DoubleJumpEndTime { get; set; }
        public double WalljumpHsp { get; set; }
        public double WalljumpVsp { get; set; }
        public int WalljumpTime { get; set; }
        //Air physics
        public double AirAcceleration { get; set; }
        public double PratFallAcceleration { get; set; }
        public double AirFriction { get; set; }
        public double MaxFallSpeed { get; set; }
        public double MaxAirSpeed { get; set; }
        public double FastFallSpeed { get; set; }
        public double GravitySpeed { get; set; }
        public double HitstunGravity { get; set; }
        public int LandTime { get; set; }
        public int PratLandTime { get; set; }
        //Evasion
        public double TechrollSpeed { get; set; }
        public double AirDodgeSpeed { get; set; }
        public double RollForwardMax { get; set; }
        public double RollBackwardMax { get; set; }

        public long Id { get; }

        public Fighter(long id)
        {
            foreach(FighterScriptSlot slot in Enum.GetValues(typeof(FighterScriptSlot)))
            {
                scripts.Add(slot, new List<IScript>());
            }
            foreach(FighterActionSprite sprite in Enum.GetValues(typeof(FighterActionSprite)))
            {
                actionAnimations.Add(sprite, new SpriteSequence());
            }
        }
    }
}

