using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Spells
{
    public class KnightInnerStrengthSpell : MonoBehaviour
    {
        public PlayMakerFSM fsmInnerStrenght;
        public void Activate( )
        {
            PlayerTurnMgr.Instance.RepeatPlayer();
        }

    }
}