using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxMgr : MonoBehaviour {

    public GameObject trapFX;
    public GameObject rootFX;
    public GameObject freezeFX;
    public GameObject withholdAttackFX;

    private static FxMgr _instance;
    public static FxMgr Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        _instance = GetComponent<FxMgr>();
    }

    public void ActivateTrapFX(Vector3 position)
    {
        trapFX.transform.position = position + (new Vector3(0f, 1f, 0f));
        trapFX.SetActive(true);
    }

    public void DeactivateTrapFX()
    {
        trapFX.SetActive(false);
    }

    public void ActivateRootFX(Vector3 position)
    {
        rootFX.transform.position = position + (new Vector3(0f, 1f, 0f));
        rootFX.SetActive(true);
    }
    public void DeactivateRootFX()
    {
        rootFX.SetActive(false);
    }

    public void ActivateFreezeFX(Vector3 position)
    {
        freezeFX.transform.position = position + (new Vector3(0f, 1f, 0f));
        freezeFX.SetActive(true);
    }
    public void DeactivateFreezeFX()
    {
        freezeFX.SetActive(false);
    }

    public void ActivateWithholdAttackFX(Vector3 position)
    {
        withholdAttackFX.transform.position = position + (new Vector3(0f, 1f, 0f));
        withholdAttackFX.SetActive(true);
    }
    public void DeactivateWithholdAttackFX()
    {
        withholdAttackFX.SetActive(false);
    }


}
