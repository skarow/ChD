using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMgr : MonoBehaviour
{
    static ResetMgr _instance;
    static public ResetMgr Instance
    {
        get { return _instance; }
    }

    List<IResetListener> resetListeners;

    void Awake()
    {
        resetListeners = new List<IResetListener>();
        _instance = GetComponent<ResetMgr>();
    }

    public void ResetGame()
    {
        foreach ( IResetListener listener in resetListeners )
        {
            listener.OnResetGame();
        }
    }

    public void SubscribeResetListener( IResetListener listener )
    {
        resetListeners.Add(listener);
    }

    public void UnsubscribeResetListener( IResetListener listener )
    {
        resetListeners.Remove(listener);
    }

    public void ClearResetListeners()
    {
        resetListeners.Clear();
    }


}
