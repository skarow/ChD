using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellPanelBtn : MonoBehaviour {

    public EPlayerSpells spell;

    GameObject spellsPanel;
    Button button;
    GameObject skillIcon;
    Text currentPenaltyText;
    private Talent talent;

    private void Awake()
    {
        talent = TalentsHolderMgr.GetTalent(spell);
        button = GetComponent<Button>();
        // will use that to disable
        skillIcon = gameObject.transform.GetChild(0).GetChild(0).gameObject;
        skillIcon.SetActive(true);

        currentPenaltyText = skillIcon.transform.GetChild(0).GetComponent< Text>();

        spellsPanel = gameObject.transform.parent.parent.gameObject; // parent of the parent
    }

    private void OnEnable()
    {
        if (talent.TalentLevel == 0)
        {
            // no need to do anything - the talent is not active yet
            skillIcon.SetActive(false);
            button.interactable = false;
            return;
        }
        skillIcon.SetActive(true);
        button.interactable = true;
        currentPenaltyText.text = "";

        if ( talent.CurrentPenalty > 0 )
        {
            currentPenaltyText.text = talent.CurrentPenalty.ToString();
            button.interactable = false;
        }
    }

    public void OnClick()
    {
        SpellsMgr.Instance.UseSpell(spell);
        spellsPanel.SetActive(false);
    }
}
