using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INewPlayerTurnListener
{
    // called from PlayerTurnMgr
    void OnNewPlayerTurn();
}
