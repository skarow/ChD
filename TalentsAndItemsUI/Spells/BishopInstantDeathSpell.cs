using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopInstantDeathSpell
{
    public static PlayMakerFSM targetFsm;

    public static void Activate(GameObject target)
    {
        targetFsm = target.GetComponent<PlayMakerFSM>();
        if ( targetFsm)
            targetFsm.Fsm.Event("Taken");
    }
}
