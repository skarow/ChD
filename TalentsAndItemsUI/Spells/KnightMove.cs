using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Spells
{
    public class KnightMove : MonoBehaviour
    {
        public PlayMakerFSM fsmKnightMove;

        public void UseSpell( EPlayerSpells spell )
        {
            switch (spell)
            {
                case EPlayerSpells.eKnightMoveLeft:
                    fsmKnightMove.Fsm.Event("KNIGHT_MOVE_LEFT");
                    break;
                case EPlayerSpells.eKnightMoveRight:
                    fsmKnightMove.Fsm.Event("KNIGHT_MOVE_RIGHT");
                    break;
                case EPlayerSpells.eKnightMoveUp:
                    fsmKnightMove.Fsm.Event("KNIGHT_MOVE_UP");
                    break;
                case EPlayerSpells.eKnightMoveDown:
                    fsmKnightMove.Fsm.Event("KNIGHT_MOVE_DOWN");
                    break;
                default:
                    Debug.Log("Knight Move - bad event input");
                    break;
            }
        }
    }
}

