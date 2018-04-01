using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalentsPanelButton  {

    public enum EShowPenaltiesType
    {
        eNone,
        eShowPenalties,
        eShowPercentage
    }

    public EShowPenaltiesType eShowPenalties;
    public int nActivationLevel;
    public delegate int GetTotalPoints();
    public GetTotalPoints getTotalPoints;

    public Talent talent;
    // sets a text like 0/4 for current talent level
    public TalentBtnStatsInfo info;
    private bool bActive;
    private string plusOneText;

    // Use this for initialization
    public void Init()
    {
        info.SetCurrentAndMaxValues(talent.TalentLevel, talent.MaxTalentLevel);
        TryActivate();
    }

    public void OnClick()
    {
        TalentInfo_.Info.SetActive(true);
        TalentInfo_.Info.SetTitle(talent.Title);
        TalentInfo_.Info.SetDesc(talent.Desc);

        switch (eShowPenalties)
        {
            case EShowPenaltiesType.eShowPenalties:
                TalentInfo_.Info.SetPenaltyNow(talent.GetFormatedCurrentPenalties());
                TalentInfo_.Info.SetPenaltyNext(talent.GetFormatedNextPenalties());
                break;
            case EShowPenaltiesType.eShowPercentage:
                TalentInfo_.Info.SetPenaltyNow(talent.GetFormatedCurrentBonusPrecentages());
                TalentInfo_.Info.SetPenaltyNext(talent.GetFormatedBonusNextPercentages());
                break;
            case EShowPenaltiesType.eNone:
                TalentInfo_.Info.SetPenaltyNow("");
                TalentInfo_.Info.SetPenaltyNext("");
                break;
        }

        if ( bActive )
        {
            TalentInfo_.Info.m_Button.interactable = true;
            TalentInfo_.Info.m_Button.onClick.RemoveAllListeners();
            TalentInfo_.Info.m_Button.onClick.AddListener(IncreaseTalentLevel);
        }
        else
        {
            TalentInfo_.Info.m_Button.interactable = false;
        }
        TalentInfo_.Info.SetPenaltyPlusOne(plusOneText);
    }

    public void IncreaseTalentLevel()
    {
        talent.IncreaseLevel();
        talent.Save();
        TalentMgr.UsePoint();
        TalentInfo_.Info.SetActive(false);
        TalentPanelBtnMgr.Instance.TryActivate();
        Init();
    }

    public void TryActivate()
    {
        if (info == null) return;

        info.SetInactive();
        bActive = false;
        if (TalentMgr.QAvailablePoints())
        {
            if (  nActivationLevel <= getTotalPoints()  )
            {
                if ( !talent.QIsMaxLevel() )
                {
                    info.SetActive();
                    bActive = true;
                    plusOneText = "+1";
                }
                else
                {
                    plusOneText = "Max Level";
                }
            }
            else
            {
                plusOneText = "Required " + nActivationLevel + "points";
            }
        }
    }

}
