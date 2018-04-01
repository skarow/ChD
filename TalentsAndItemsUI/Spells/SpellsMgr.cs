using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsMgr : MonoBehaviour, INewPlayerTurnListener {
#region mgrs
    private Spells.KnightMove knightMove;
    private Spells.KnightInnerStrength knightIS;
    private Spells.KnightSoulLink knightSL;
    private Spells.BishopPickEnemySpells bishopPickEnemySpells;
    #endregion //mgrs

    private static SpellsMgr _instance;
    public static SpellsMgr Instance
    {
        get { return _instance;  }
    }

    void Awake()
    {
        knightMove = GetComponent<Spells.KnightMove>();
        knightIS = GetComponent<Spells.KnightInnerStrength>();
        knightSL = GetComponent<Spells.KnightSoulLink>();
        bishopPickEnemySpells = GetComponent<Spells.BishopPickEnemySpells>();
        _instance = GetComponent<SpellsMgr>();
    }

    void Start()
    {
        PlayerTurnMgr.Instance.SubscribeForNewTurnNotification(this);
    }

    void INewPlayerTurnListener.OnNewPlayerTurn()
    {
        TalentsHolderMgr.DecreasePenalty();
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
                knightMove.UseSpell(spell);
                break;
            case EPlayerSpells.eKnightInnerStrength:
                knightIS.UseSpell(spell);
                break;
            case EPlayerSpells.eKnightSoulLink:
                knightSL.UseSpell(spell);
                break;
            case EPlayerSpells.eBishopWithholdEnemy:
            case EPlayerSpells.eBishopEntangle:
            case EPlayerSpells.eBishopFreeze:
            case EPlayerSpells.eBishopInstantDeath:
                bishopPickEnemySpells.Activate(spell);
                break;

        }
    }
}
