using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class IAPadapter : MonoBehaviour {

    public PlayMakerFSM doubleMoveMgr;
    public PlayMakerFSM switchOrderMgr;

    public void BuyDoubleMove3()
    {
        IAPStoreMgr.instance.BuyDoubleMoves_3();
        doubleMoveMgr.Fsm.Event("SAVE");
    }

    public void BuyDoubleMove8()
    {
        IAPStoreMgr.instance.BuyDoubleMoves_8();
        doubleMoveMgr.Fsm.Event("SAVE");
    }

    public void BuyDoubleMove12()
    {
        IAPStoreMgr.instance.BuyDoubleMoves_12();
        doubleMoveMgr.Fsm.Event("SAVE");
    }

    public void BuySwitchOrder3()
    {
        IAPStoreMgr.instance.BuySwitchOrder_3();
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuySwitchOrder8()
    {
        IAPStoreMgr.instance.BuySwitchOrder_8();
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuySwitchOrder12()
    {
        IAPStoreMgr.instance.BuySwitchOrder_12();
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuyOfEach3()
    {
        IAPStoreMgr.instance.BuyOfEach_3();
        doubleMoveMgr.Fsm.Event("SAVE");
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuyOfEach8()
    {
        IAPStoreMgr.instance.BuyOfEach_8();
        doubleMoveMgr.Fsm.Event("SAVE");
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuyOfEach12()
    {
        IAPStoreMgr.instance.BuyOfEach_12();
        doubleMoveMgr.Fsm.Event("SAVE");
        switchOrderMgr.Fsm.Event("SAVE");
    }

    public void BuyAllowTopRow()
    {
        IAPStoreMgr.instance.BuyTopRowMovement();
    }

    public void BuyAct2()
    {
        IAPStoreMgr.instance.BuyAct2();
    }

    public void BuyPremiumFigureSkin()
    {
        IAPStoreMgr.instance.BuyPremiumFigureSkin();
    }
}
