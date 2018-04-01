using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopWithholdEnemySpell : MonoBehaviour {

    public static PlayMakerFSM targetFsm;
    static int duratation;

    public static void Activate(GameObject target)
    {
        duratation = 2;
        targetFsm = target.GetComponent<PlayMakerFSM>();

        targetFsm.Fsm.Event("SET_STOP_ATTACK");
        FxMgr.Instance.ActivateWithholdAttackFX(target.transform.position);
    }

    private static void UpdatePosition()
    {
        if ( targetFsm != null)
            FxMgr.Instance.ActivateWithholdAttackFX(targetFsm.transform.position);
    }

    public static void Tick()
    {
        if (duratation > 1)
        {
            UpdatePosition();
            duratation--;
        }
        else if (duratation == 1)
        {
            duratation--;

            targetFsm.Fsm.Event("UNSTOP_ATTACK");
            FxMgr.Instance.DeactivateWithholdAttackFX();
            targetFsm = null;
        }
    }
}
