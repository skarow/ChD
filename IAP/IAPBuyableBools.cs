using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class IAPBuyableBools : MonoBehaviour {

    const string ADDITIONAL_FIELDS = "bBoughtAdditionalFields";
    const string ACT_2= "bBoughtAct2";
    const string PREMIUM_SKIN = "bBoughtPremiumSkin";

    private FsmBool allowTopRow;
    private FsmBool act2Enabled;
    private FsmBool premiumFiguresEnabled;

    // Use this for initialization
    void Start () {
        allowTopRow = FsmVariables.GlobalVariables.GetFsmBool("bBoughtAdditionalFields");
        act2Enabled = FsmVariables.GlobalVariables.GetFsmBool("bBoughtAct2");
        premiumFiguresEnabled = FsmVariables.GlobalVariables.GetFsmBool("bBoughtPremiumSkin");
        GetPlayerPrefs();
    }

    void GetPlayerPrefs()
    {
        GetAdditionalFieldsPrefs();
        GetAct2Prefs();
        GetPremiumSkinPrefs();
    }

    void GetAdditionalFieldsPrefs()
    {
        if (PlayerPrefs.HasKey(ADDITIONAL_FIELDS))
        {
            int intTest = PlayerPrefs.GetInt(ADDITIONAL_FIELDS);
            if (intTest == 0)
                allowTopRow.Value = false;
            else
                allowTopRow.Value = true;
        }
        else
        {
            PlayerPrefs.SetInt(ADDITIONAL_FIELDS, 0);
            allowTopRow.Value = false;
        }
    }

    void GetAct2Prefs()
    {
        if (PlayerPrefs.HasKey(ACT_2))
        {
            int intTest = PlayerPrefs.GetInt(ACT_2);
            if (intTest == 0)
                act2Enabled.Value = false;
            else
                act2Enabled.Value = true;
        }
        else
        {
            PlayerPrefs.SetInt(ACT_2, 0);
            act2Enabled.Value = false;
        }
    }

    void GetPremiumSkinPrefs()
    {
        if (PlayerPrefs.HasKey(PREMIUM_SKIN))
        {
            int intTest = PlayerPrefs.GetInt(PREMIUM_SKIN);
            if (intTest == 0)
                premiumFiguresEnabled.Value = false;
            else
                premiumFiguresEnabled.Value = true;
        }
        else
        {
            PlayerPrefs.SetInt(PREMIUM_SKIN, 0);
            premiumFiguresEnabled.Value = false;
        }
    }

    static public void SaveAdditionalFields()
    {
        PlayerPrefs.SetInt(ADDITIONAL_FIELDS, 1);
    }

    static public void SaveAct2()
    {
        PlayerPrefs.SetInt(ACT_2, 1);
    }

    static public void SavePremiumFigures()
    {
        PlayerPrefs.SetInt(PREMIUM_SKIN, 1);
    }
}

