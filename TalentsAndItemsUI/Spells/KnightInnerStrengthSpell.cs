using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Spells
{
    public class KnightInnerStrengthSpell : MonoBehaviour
    {
        public PlayMakerFSM fsmInnerStrenght;
        public void UseSpell( EPlayerSpells spell )
        {
            if ( spell == EPlayerSpells.eKnightInnerStrength)
            {
                fsmInnerStrenght.Fsm.Event("USE_DOUBLE_MOVE");
            }
        }

    }
}