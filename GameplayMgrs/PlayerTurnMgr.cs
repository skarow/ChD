using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnMgr : MonoBehaviour, IResetListener {

    // temporary FSM connection
    public PlayMakerFSM enemyTurnMgrFSM;
    PlayMakerFSM playerTurnMgrFSM;

    List<INewPlayerTurnListener> newTurnListeners;
    List<IPlayerController> players;

    int nRepeatPlayerCount;
    bool bCurrentActiveBishop;
    private static PlayerTurnMgr _instance;
    public static PlayerTurnMgr Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        nRepeatPlayerCount = 0;
        bCurrentActiveBishop = false;
        newTurnListeners = new List<INewPlayerTurnListener>();
        _instance = GetComponent<PlayerTurnMgr>();
        playerTurnMgrFSM = GetComponent<PlayMakerFSM>();
    }
    private void Start()
    {
        players = new List<IPlayerController>()
        {
            PlayerKnight.Instance,
            PlayerBishop.Instance
        };
        ResetMgr.Instance.SubscribeResetListener(this);
    }

    void IResetListener.OnResetGame()
    {
        bCurrentActiveBishop = false;
        players[0].Reset();
        players[1].Reset();
        // activate knight
        //players[0].Activate();
        NotifyNewTurnListeners();
    }

    public void ChangeCurrentActivePlayer()
    {
        int activeIndex = System.Convert.ToInt32(bCurrentActiveBishop);
        if (nRepeatPlayerCount > 0)
        {
            players[activeIndex].Activate();
            nRepeatPlayerCount--;
        }
        // change player
        bCurrentActiveBishop = !bCurrentActiveBishop;
        activeIndex = System.Convert.ToInt32(bCurrentActiveBishop);

        if ( !players[activeIndex].HasMoved() )
        {
            players[activeIndex].Activate();
        }
        else
        {
            enemyTurnMgrFSM.Fsm.Event("EnemyTurn");
        }
    }

    public void RepeatPlayer()
    {
        //playerTurnMgrFSM.Fsm.Event("REPEAT_PLAYER");
        nRepeatPlayerCount++;
    }

    public void NotifyNewTurnListeners()
    {
        foreach ( INewPlayerTurnListener listener in newTurnListeners )
        {
            listener.OnNewPlayerTurn();
        }
        // activate knight
        players[0].Activate();
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
