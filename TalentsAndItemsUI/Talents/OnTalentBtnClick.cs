using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTalentBtnClick : MonoBehaviour {

    public EPlayerSpells eKnightSpell;

    public void OnClick()
    {
        TalentPanelBtnMgr.Instance.ClickSpell(eKnightSpell);
    }
}
