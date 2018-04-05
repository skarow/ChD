using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsMgr : MonoBehaviour, INewPlayerTurnListener {

    #region mgrs
    private Spells.KnightMoveSpell knightMove;
    private Spells.KnightInnerStrengthSpell knightIS;
    private Spells.KnightSoulLinkSpell knightSL;
    private Spells.BishopPickEnemySpells bishopPickEnemySpells;
    private Spells.BishopPushEnemySpell bishopPushEnemySpell;
    private Spells.BishopThornTrapSpell bishopThornTrapSpell;
    #endregion //mgrs

    private static SpellsMgr _instance;
    public static SpellsMgr Instance
    {
        get { return _instance;  }
    }

    void Awake()
    {
        knightMove = GetComponent<Spells.KnightMoveSpell>();
        knightIS = GetComponent<Spells.KnightInnerStrengthSpell>();
        knightSL = GetComponent<Spells.KnightSoulLinkSpell>();
        bishopPickEnemySpells = GetComponent<Spells.BishopPickEnemySpells>();
        bishopPushEnemySpell = GetComponent<Spells.BishopPushEnemySpell>();
        bishopThornTrapSpell = GetComponent<Spells.BishopThornTrapSpell>();
        _instance = GetComponent<SpellsMgr>();
    }

    void Start()
    {
        PlayerTurnMgr.Instance.SubscribeForNewTurnNotification(this);
    }

    void INewPlayerTurnListener.OnNewPlayerTurn()
    {
        TalentsHolderMgr.DecreasePenalty();
        bishopThornTrapSpell.Tick();
        BishopRootSpell.Tick();
        BishopWithholdEnemySpell.Tick();
    }

    public void UseSpell( EPlayerSpells spell )
    {
        TalentsHolderMgr.UseSpell(spell);
        switch (spell)
        {
            case EPlayerSpells.eKnightMoveUp:
            case EPlayerSpells.eKnightMoveDown:
            case EPlayerSpells.eKnightMoveLeft:
            case EPlayerSpells.eKnightMoveRight:
                knightMove.Activate(spell);
                break;
            case EPlayerSpells.eKnightInnerStrength:
                knightIS.Activate();
                break;
            case EPlayerSpells.eKnightSoulLink:
                knightSL.Activate();
                break;
            case EPlayerSpells.eBishopWithholdEnemy:
            case EPlayerSpells.eBishopEntangle:
            case EPlayerSpells.eBishopFreeze:
            case EPlayerSpells.eBishopInstantDeath:
                bishopPickEnemySpells.Activate(spell);
                break;
            case EPlayerSpells.eBishopPushUp:
            case EPlayerSpells.eBishopPushDown:
            case EPlayerSpells.eBishopPushLeft:
            case EPlayerSpells.eBishopPushRight:
                bishopPushEnemySpell.Activate(spell);
                break;
            case EPlayerSpells.eBishopThornTrap:
                bishopThornTrapSpell.Activate();
                break;
            case EPlayerSpells.eBishopClearTrap:
                bishopThornTrapSpell.ClearThornTrap();
                break;

        }
    }
}
