using Domain.Core.Exceptions;
using Domain.Core.ValueObjects;

using System.Collections.Generic;
using System.Linq;

namespace Domain.Core.Entities
{
    //This could possibly be an unnecessary class considering how anemic these domain classes turned out to be.
    //There's no business logic that seems to go into this stuff. They just seem like PODs.
    public class FighterConfiguration
    {
        public string Name { get; set; }
        public virtual float KnockbackAdjustment { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Ground Movement
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Walk movement vars
        /*public virtual float WalkSpeed { get; set; }
        public virtual float WalkAccel { get; set; }
        public virtual int WalkTurnTime { get; set; }

        //Dash movement vars
        public virtual int InitialDashTime { get; set; }
        public virtual int InitialDashSpeed { get; set; }
        public virtual float DashSpeed { get; set; }
        public virtual int DashTurnTime { get; set; }
        public virtual float DashTurnAccel { get; set; }
        public virtual float DashStopTime { get; set; }
        public virtual float DashStopPercent { get; set; }

        //Ground friction
        public virtual float GroundFriction { get; set; }
        public virtual float MoonwalkAccel { get; set; }

        //Wavedash junk
        public virtual int WaveLandTime { get; set; }
        public virtual float WaveLandAdj { get; set; }
        public virtual float WaveFriction { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Air Movement
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Jump
        public virtual int JumpStartTime { get; set; }
        public virtual float JumpSpeed { get; set; }
        public virtual float ShortHopSpeed { get; set; }
        public virtual float LeaveGroundMax { get; set; }
        public virtual float DoubleJumpSpeed { get; set; }
        public virtual float MaxJumpHsp { get; set; }
        public virtual float JumpChange { get; set; }
        public virtual int MaxDoubleJumps { get; set; }
        public virtual int DoubleJumpTime { get; set; }
        public virtual float WalljumpHsp { get; set; }
        public virtual float WalljumpVsp { get; set; }
        public virtual int WalljumpTime { get; set; }

        //Air Physics
        public virtual float AirAccel { get; set; }
        public virtual float PratFallAccel { get; set; }
        public virtual float AirFriction { get; set; }
        public virtual float MaxFall { get; set; }
        public virtual float AirMaxSpeed { get; set; }
        public virtual float FastFall { get; set; }
        public virtual float GravitySpeed { get; set; }
        public virtual float HitstunGravity { get; set; }

        //Landing time
        public virtual int LandTime { get; set; }
        public virtual int PratLandTime { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Evasion
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //Sport Dodge
        public virtual FighterActionWindow SpotDodge { get; set; }
        //Tech Data
        public virtual int TechActiveFrames { get; set; }
        public virtual int TechRecoveryFrames { get; set; }
        public virtual int TechrollStartupFrames { get; set; }
        public virtual int TechrollActiveFrames { get; set; }
        public virtual int TechrollRecoveryFrames { get; set; }
        public virtual float TechrollSpeed { get; set; }

        //Air Dodge
        public virtual FighterActionWindow AirDodge { get; set; }
        public virtual float AirDodgeSpeed { get; set; }

        //Roll
        public virtual FighterActionWindow RollForward { get; set; }
        public virtual FighterActionWindow RollBackward { get; set; }
        public virtual int RollForwardMax { get; set; }
        public virtual int RollBackwardMax { get; set; }

        //Crouch
        public virtual FighterActionWindow Crouch { get; set; }

        //Bubble
        public virtual Vector2 BubbleOffset { get; set; }

        //Hurtboxes
        public virtual uint FighterHeight { get; set; }
        public virtual Hurtbox IdleHurtbox { get; set; }
        public virtual Hurtbox AirHurtbox { get; set; }
        public virtual Hurtbox CrouchHurtbox { get; set; }
        public virtual Hurtbox HitstunHurtbox { get; set; }

        public virtual ISet<Attack> Attacks { get; private set; } = new HashSet<Attack>();
        public virtual IDictionary<string, object> Parameters { get; private set; } = new Dictionary<string, object>();
        public virtual IList<ColorProfile> ColorPalette { get; private set; } = new List<ColorProfile>();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Sounds
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual SoundEffect LandSoundId { get; set; }
        public virtual SoundEffect LandingLagSoundId { get; set; }
        public virtual SoundEffect WavelandSoundId { get; set; }
        public virtual SoundEffect JumpSound { get; set; }
        public virtual SoundEffect DoubleJumpSound { get; set; }
        public virtual SoundEffect AirDodgeSound { get; set; }*/

        public string[] Info { get; private set; } = new string[3];

        public Guid PortraitSprite { get; set; }

        public Guid FighterSelectSprite { get; set; }

        public Guid ResultsScreenSprite { get; set; }

        public Guid IconSprite { get; set; }

        public IDictionary<string, AnimationData> AnimData = new Dictionary<string, AnimationData>();

        public IDictionary<BaseFighterSound, Guid> FighterSounds = new Dictionary<BaseFighterSound, Guid>();

        /// <summary> Multiplier for all knockback dealt to the character </summary>
        public float KnockbackAdjustment { get; set; }

        public FighterHurtboxData FighterHurtboxData { get; set; }

        public FighterGroundMovement GroundMovement { get; set; }

        public FighterAirMovement AirMovement { get; set; }

        public FighterEvasionData EvasionData { get; set; }

        public Vector2D BubbleOffset { get; set; }

        public IDictionary<Guid, Attack> Attacks { get; private set; } = new Dictionary<Guid, Attack>();

        public IDictionary<string, object> Parameters { get; private set; } = new Dictionary<string, object>();

        public IList<ColorProfile> ColorPalette { get; private set; } = new List<ColorProfile>();

        public FighterSoundData SoundData { get; set; }

        public virtual void RenameAttack(Attack attack, string name)
        {
            if(Attacks.Any((atk)=>atk.AttackName.Equals(name) && atk.Id != attack.Id))
            {
                throw new DuplicateAttackNameException();
            }
            Attacks.First((atk)=>atk.Id == attack.Id).AttackName = name;
        }
    }
}
