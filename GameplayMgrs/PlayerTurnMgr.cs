using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnMgr : MonoBehaviour {

    List<INewPlayerTurnListener> newTurnListeners;

    private static PlayerTurnMgr _instance;
    public static PlayerTurnMgr Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        newTurnListeners = new List<INewPlayerTurnListener>();
        _instance = GetComponent<PlayerTurnMgr>();
    }

    public void NotifyNewTurnListeners()
    {
        foreach ( INewPlayerTurnListener listener in newTurnListeners )
        {
            listener.OnNewPlayerTurn();
        }
    }

    public void SubscribeForNewTurnNotification( INewPlayerTurnListener listener)
    {
        newTurnListeners.Add(listener);
    }

    public void UnsubscribeForNewTurnNotification( INewPlayerTurnListener listener )
    {
        newTurnListeners.Remove(listener);
    }

    public void ClearNewTurnListeners()
    {
        newTurnListeners.Clear();
    }
}
