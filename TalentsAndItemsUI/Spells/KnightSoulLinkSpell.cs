using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spells
{
    public class KnightSoulLinkSpell : MonoBehaviour
    {

        public PlayMakerFSM fsmKnightSoulLink;

        public void Activate()
        {
            PlayerTurnMgr.Instance.ChangeCurrentActivePlayer();
            TalentsHolderMgr.SetZeroPenalty();
        }
    }

}
