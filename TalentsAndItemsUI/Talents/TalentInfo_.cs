using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalentInfo_ : MonoBehaviour {

    public Text m_textTitle;
    public Text m_textDesc;
    public Text m_textPenaltyNow;
    public Text m_textPenaltyNext;
    public Text m_textPlusOne;
    public Button m_Button;



    private static TalentInfo_ _talentInfo; // set in TalenPanelBtnMgr
    public static TalentInfo_ Info
    {
        set { _talentInfo = value; }
        get { return _talentInfo; }
    }
    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }
    public void SetTitle( string title )
    {
        m_textTitle.text = title;
    }
    public void SetDesc ( string desc )
    {
        m_textDesc.text = desc;
    }
    public void SetPenaltyNow(string penalty)
    {
        m_textPenaltyNow.text = penalty;
    }
    public void SetPenaltyNext(string penalty)
    {
        m_textPenaltyNext.text = penalty;
    }
    public void SetPenaltyPlusOne(string plusOne)
    {
        m_textPlusOne.text = plusOne;
    }
}

