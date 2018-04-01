using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TalentBtn
{
    [System.Serializable]
    public struct StatsInfo
    {
        public EPlayerSpells spell;
        public TalentBtnStatsInfo btnInfo;
    }
}


public class TalentPanelBtnMgr : MonoBehaviour {

    [Header("Stat info")]
    public TalentBtn.StatsInfo[] statsInfo;
    [Header("Settables")]
    public Text textAvailableTalenPoints;
    public GameObject info;

    public Dictionary<EPlayerSpells, TalentsPanelButton> talentButtons;

    static TalentPanelBtnMgr instance_;
    public static TalentPanelBtnMgr Instance
    {
        get { return instance_;  }
    }
    private void Awake()
    {
        instance_ = GetComponent<TalentPanelBtnMgr>();
        TalentInfo_.Info = info.GetComponent<TalentInfo_>();
    }
    void Start()
    {
        CreateKnightTalents();
        InitTalentButtons();
        textAvailableTalenPoints.text = TalentMgr.GetAvailablePoints().ToString();
    }

    TalentBtnStatsInfo FindStatsInfo( EPlayerSpells spell )
    {
        foreach ( var knInfoPair in statsInfo)
        {
            if ( knInfoPair.spell == spell )
            {
                return knInfoPair.btnInfo;
            }
        }
        return null;
    }

    public void ClickSpell(EPlayerSpells spell)
    {
        talentButtons[spell].OnClick();
    }
    
    public void TryActivate()
    {
        textAvailableTalenPoints.text = TalentMgr.GetAvailablePoints().ToString();
        foreach (var knButtonPair in talentButtons)
        {
            knButtonPair.Value.TryActivate();
        }
    }

    void CreateKnightTalents()
    {
        talentButtons = new Dictionary<EPlayerSpells, TalentsPanelButton>
        {
            {
                EPlayerSpells.eKnightMoveLeft,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 4,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightMoveLeft),
                    info = FindStatsInfo(EPlayerSpells.eKnightMoveLeft),
                }
            },
            {
                EPlayerSpells.eKnightMoveRight,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 4,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightMoveRight),
                    info = FindStatsInfo(EPlayerSpells.eKnightMoveRight),
                }
            },

            {
                EPlayerSpells.eKnightMoveUp,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 0,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightMoveUp),
                    info = FindStatsInfo(EPlayerSpells.eKnightMoveUp),
                }
            },

            {
                EPlayerSpells.eKnightMoveDown,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 0,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightMoveDown),
                    info = FindStatsInfo(EPlayerSpells.eKnightMoveDown),
                }
            },

            {
                EPlayerSpells.eKnightSwiftJustice,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 8,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightSwiftJustice),
                    info = FindStatsInfo(EPlayerSpells.eKnightSwiftJustice),
                }
            },

            {
                EPlayerSpells.eKnightInnerStrength,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 12,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightInnerStrength),
                    info = FindStatsInfo(EPlayerSpells.eKnightInnerStrength),
                }
            },

            {
                EPlayerSpells.eKnightInnerStrengthEnhanced,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPercentage,
                    nActivationLevel = 16,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightInnerStrengthEnhanced),
                    info = FindStatsInfo(EPlayerSpells.eKnightInnerStrengthEnhanced),
                }
            },

            {
                EPlayerSpells.eKnightSoulLink,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 16,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightSoulLink),
                    info = FindStatsInfo(EPlayerSpells.eKnightSoulLink),
                }
            },

            {
                EPlayerSpells.eKnightCutTies,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eNone,
                    nActivationLevel = 20,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightCutTies),
                    info = FindStatsInfo(EPlayerSpells.eKnightCutTies),
                }
            },

            {
                EPlayerSpells.eKnightMastery,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eNone,
                    nActivationLevel = 20,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightMastery),
                    info = FindStatsInfo(EPlayerSpells.eKnightMastery),
                }
            },

            {
                EPlayerSpells.eKnightRebirth,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPercentage,
                    nActivationLevel = 20,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eKnightRebirth),
                    info = FindStatsInfo(EPlayerSpells.eKnightRebirth),
                }
            },
            {
                EPlayerSpells.eBishopPushUp,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 0,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopPushUp),
                    info = FindStatsInfo(EPlayerSpells.eBishopPushUp),
                }
            },

            {
                EPlayerSpells.eBishopPushDown,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 0,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopPushDown),
                    info = FindStatsInfo(EPlayerSpells.eBishopPushDown),
                }
            },

            {
                EPlayerSpells.eBishopPushLeft,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 4,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopPushLeft),
                    info = FindStatsInfo(EPlayerSpells.eBishopPushLeft),
                }
            },

            {
                EPlayerSpells.eBishopPushRight,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 4,
                    getTotalPoints = TalentsHolderMgr.TotalKnightPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopPushRight),
                    info = FindStatsInfo(EPlayerSpells.eBishopPushRight),
                }
            },

            {
                EPlayerSpells.eBishopThornTrap,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 0,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopThornTrap),
                    info = FindStatsInfo(EPlayerSpells.eBishopThornTrap),
                }
            },

            {
                EPlayerSpells.eBishopClearTrap,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 4,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopClearTrap),
                    info = FindStatsInfo(EPlayerSpells.eBishopClearTrap),
                }
            },

            {
                EPlayerSpells.eBishopWithholdEnemy,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 8,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopWithholdEnemy),
                    info = FindStatsInfo(EPlayerSpells.eBishopWithholdEnemy),
                }
            },

            {
                EPlayerSpells.eBishopEntangle,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 12,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopEntangle),
                    info = FindStatsInfo(EPlayerSpells.eBishopEntangle),
                }
            },

            {
                EPlayerSpells.eBishopFreeze,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPercentage,
                    nActivationLevel = 16,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopFreeze),
                    info = FindStatsInfo(EPlayerSpells.eBishopFreeze),
                }
            },

            {
                EPlayerSpells.eBishopInstantDeath,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eShowPenalties,
                    nActivationLevel = 16,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopInstantDeath),
                    info = FindStatsInfo(EPlayerSpells.eBishopInstantDeath),
                }
            },

            {
                EPlayerSpells.eBishopMastery,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eNone,
                    nActivationLevel = 20,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopMastery),
                    info = FindStatsInfo(EPlayerSpells.eBishopMastery),
                }
            },

            {
                EPlayerSpells.eBishopCutTies,
                new TalentsPanelButton
                {
                    eShowPenalties = TalentsPanelButton.EShowPenaltiesType.eNone,
                    nActivationLevel = 20,
                    getTotalPoints = TalentsHolderMgr.TotalBishopPoints,
                    talent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopCutTies),
                    info = FindStatsInfo(EPlayerSpells.eBishopCutTies),
                }
            },
        };
    }

    public void InitTalentButtons()
    {
        foreach (var btn in talentButtons)
        {
            btn.Value.Init();
        }
    }
}
