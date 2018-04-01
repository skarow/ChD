using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownPenalty
{
    public CooldownPenalty(int lcd, int gcd) { globalCooldown = gcd; localCooldown = lcd; }
    public int globalCooldown;
    public int localCooldown;
}

public class Talent
{
    private const string MAX_TALANT_LEVEL = "maxTalantLevel"; // max talent level set by the user
    private const string TALANT_LEVEL = "talantLevel"; // talent level that was set by the user

    public Talent() { TalentLevel = 0; maxTalentLevel = 0; CurrentPenalty = 0; }
    public bool IsMaxLevel() { return TalentLevel == levelDef.Count; }

    public void IncreaseLevel() { TalentLevel = TalentLevel + 1; upgradedTalentLevel++; }
    public void DecreaseLevel() { if (talentLevel > 0) TalentLevel = TalentLevel - 1; upgradedTalentLevel--; }
    public void DecreasePenalty()
    {
        if (currentPenalty > 0) currentPenalty--;
    }

    public string GetFormatedNextPenalties()
    {
        return "-LCD".PadRight(6) + levelDef[upgradedTalentLevel + 1].localCooldown.ToString().PadLeft(2) + " turns\n" + "-GCD".PadRight(6) + levelDef[upgradedTalentLevel + 1].globalCooldown.ToString().PadLeft(2) + " turns";
    }
    public string GetFormatedCurrentPenalties()
    {
        if (talentLevel == 0)
        {
            return "You haven't learnt that skill yet";
        }
        return "-LCD".PadRight(6) + levelDef[upgradedTalentLevel].localCooldown.ToString().PadLeft(2) + " turns\n" + "-GCD".PadRight(6) + levelDef[upgradedTalentLevel].globalCooldown.ToString().PadLeft(2) + " turns";
    }
    public string GetFormatedCurrentBonusPrecentages()
    {
        if (talentLevel == 0) return "You haven't learnt that skill yet";
        return "Chance: " + levelDef[upgradedTalentLevel].localCooldown.ToString().PadLeft(2) + "%";
    }
    public string GetFormatedBonusNextPercentages()
    {
        return "Chance: " + levelDef[upgradedTalentLevel + 1].localCooldown.ToString().PadLeft(2) + "%";
    }

    public int GetBonusPercentage()
    {
        if (TalentLevel == 0) return 0;
        return levelDef[talentLevel].localCooldown;
    }

    public bool QIsMaxLevel() { return talentLevel == maxTalentLevel; }

    public void Save()
    {
        PlayerPrefs.SetInt(Name + MAX_TALANT_LEVEL, maxTalentLevel);
        PlayerPrefs.SetInt(Name + TALANT_LEVEL, talentLevel);
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey(Name + MAX_TALANT_LEVEL))
        {
            //maxTalentLevel = PlayerPrefs.GetInt(Name + MAX_TALANT_LEVEL);
        }
        if (PlayerPrefs.HasKey(Name + TALANT_LEVEL))
        {
            talentLevel = PlayerPrefs.GetInt(Name + TALANT_LEVEL);
        }
        upgradedTalentLevel = talentLevel;
    }

    public List<CooldownPenalty> levelDef;
    // talent levels
    private int maxTalentLevel;
    private int talentLevel;
    private int upgradedTalentLevel;
    private int currentPenalty;

    public string Name { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }

    public int MaxTalentLevel
    {
        get
        {
            return maxTalentLevel;
        }

        set
        {
            maxTalentLevel = value;
        }
    }
    public int TalentLevel
    {
        get
        {
            return talentLevel;
        }

        set
        {
            talentLevel = value;
        }
    }
    public int UpgradedTalentLevel
    {
        get
        {
            return upgradedTalentLevel;
        }

        set
        {
            upgradedTalentLevel = value;
        }
    }
    public int CurrentPenalty
    {
        get
        {
            return currentPenalty;
        }

        set
        {
            currentPenalty = value;
        }
    }

}