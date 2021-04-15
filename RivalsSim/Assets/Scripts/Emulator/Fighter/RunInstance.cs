using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*public enum PlayerState
{
    PS_WALK,
    PS_WALK_TURN,
    PS_DASH_START,
    PS_DASH,
    PS_DASH_STOP,
    PS_DASH_TURN,
    PS_WAVELAND,

    PS_AIR_DODGE,
    PS_PARRY_START,
    PS_PARRY,
    PS_ROLL_BACKWARD,
    PS_ROLL_FORWARD,
    PS_TECH_GROUND,
    PS_TECH_BACKWARD,
    PS_TECH_FORWARD,
    PS_WALL_TECH,

    PS_WRAPPED,
    PS_FROZEN,

    PS_IDLE,
    PS_IDLE_AIR,
    PS_CROUCH,
    PS_JUMPSQUAT,
    PS_FIRST_JUMP,
    PS_DOUBLE_JUMP,
    PS_WALL_JUMP,
    PS_LAND,

    PS_HITSTUN,
    PS_HITSTUN_LAND,
    PS_TUMBLE,
    PS_PRATFALL,
    PS_PRATLAND,

    PS_SPAWN,
    PS_RESPAWN,
    PS_DEAD
}

enum StateCategory
{
    SC_HITSTUN,
    SC_AIR_NEUTRAL,
    SC_AIR_COMMITTED,
    SC_GROUND_NEUTRAL,
    SC_GROUND_COMMITTED
}*/

//Figure out how variables are going to work for the player 
public class CharacterInstance //: RunObject
{

    [SerializeField]
    private Collider2D ecb;

    private void Update()
    {

        //PhysicsUtil.CorrectMovement();
    }
}
