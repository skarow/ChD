using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopRootSpell
{
    public static PlayMakerFSM targetFsm;
    static int duratation;
    static bool freeze;

    public static void Activate( GameObject target )
    {
        duratation = 1;
        targetFsm = target.GetComponent<PlayMakerFSM>();
        int freezePercentage = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopFreeze).GetBonusPercentage();
        int rnd = Random.Range(0, 100);
        if ( rnd < freezePercentage )
        { // freeze
            freeze = true;
            targetFsm.Fsm.Event("SET_FROZEN");
            FxMgr.Instance.ActivateFreezeFX(target.transform.position);
        }
        else // root
        {
            targetFsm.Fsm.Event("SET_ROOTED");
            FxMgr.Instance.ActivateRootFX(target.transform.position);
        }
    }

    public static void Tick()
    {
        if ( duratation > 1)
        {
            duratation--;
        }
        if ( duratation == 1 )
        {
            duratation--;
            if (freeze)
            {
                targetFsm.Fsm.Event("UNFREEZE");
                FxMgr.Instance.DeactivateFreezeFX();
            }
            else
            {
                targetFsm.Fsm.Event("UNROOT");
                FxMgr.Instance.DeactivateRootFX();
            }
        }
    }

}
