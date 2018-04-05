using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PickObject", menuName = "scriptable/PickObject")]
public class PickObject : ScriptableObject {

    public int[] layerMaskArray;
    public int pickDistance = 100;

    // used to lower the raycast point beneath the board so that the raycast can always be UP
    Vector3 submurgePoint = new Vector3(0f, 5f, 0f);
    int layerMask;

    void LayerArrayToLayerMask()
    {
        layerMask = 0;
        foreach (int layer in layerMaskArray)
            layerMask = layerMask | 1 << layer;
    }

    public GameObject GetTouchedObject()
    {
        LayerArrayToLayerMask();

#if (UNITY_IPHONE || UNITY_IOS || UNITY_ANDROID)
        if (Input.touchCount > 0)
        {
            var touch = Input.touches[0];
            var screenPos = touch.position;

            RaycastHit hitInfo;
            if (layerMask != 0)
                Physics.Raycast(Camera.main.ScreenPointToRay(screenPos), out hitInfo, pickDistance, layerMask);
            else
            {
                Physics.Raycast(Camera.main.ScreenPointToRay(screenPos), out hitInfo, pickDistance);
            }
            return hitInfo.transform.gameObject;
        }
#endif //(UNITY_IPHONE || UNITY_IOS || UNITY_ANDROID)

#if UNITY_EDITOR
        if (Input.GetButtonDown("Fire1"))
        {
            var screenPos = Input.mousePosition;
            RaycastHit hitInfo;

            if (layerMask != 0)
                Physics.Raycast(Camera.main.ScreenPointToRay(screenPos), out hitInfo, pickDistance, layerMask);
            else
            {
                Physics.Raycast(Camera.main.ScreenPointToRay(screenPos), out hitInfo, pickDistance);
            }
            if (hitInfo.transform)
                return hitInfo.transform.gameObject;
        }
#endif // UNITY_EDITOR
        return null;
    }

    // ex. An object sitting in a game field
    public bool CheckForObjectInPosition( Vector3 position)
    {
        LayerArrayToLayerMask();

        RaycastHit hitInfo;
        Physics.Raycast(position - submurgePoint, new Vector3(0f, 90f, 0f), out hitInfo, 30, layerMask);
        if ( hitInfo.transform )
        {
            return true;
        }
        return false;
    }

    public GameObject GetObjectInPosition( Vector3 position )
    {
        LayerArrayToLayerMask();

        RaycastHit hitInfo;
        Physics.Raycast(position - submurgePoint, Vector3.up/*new Vector3(0f, 90f, 0f)*/, out hitInfo, 30, layerMask);
        if (hitInfo.transform)
        {
            return hitInfo.transform.gameObject;
        }
        return null;
    }

}
