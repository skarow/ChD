using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spells
{
    public class KnightSoulLinkSpell : MonoBehaviour
    {

        public PlayMakerFSM fsmKnightSoulLink;

        public void UseSpell(EPlayerSpells spell)
        {
            if (spell == EPlayerSpells.eKnightSoulLink)
            {
                fsmKnightSoulLink.Fsm.Event("USE_SWITCHES");
            }
        }
    }

}
