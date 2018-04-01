using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TalentMgr  {

    private const string AVAILABLE_TALENT_COUNT_PREFS = "AVAILABLE_TALENT_COUNT_PREFS";

    public static int GetAvailablePoints() { return nAvailablePoints; }
    public static bool QAvailablePoints() { return nAvailablePoints > 0; }
    public static void AddPoint() { nAvailablePoints++; Save(); }
    public static void UsePoint() { nAvailablePoints--; Save(); }

    static TalentMgr()
    {
        Load();
        nAvailablePoints = 2;
    }

    static void Load()
    {
        if (PlayerPrefs.HasKey(AVAILABLE_TALENT_COUNT_PREFS))
        {
            nAvailablePoints = PlayerPrefs.GetInt(AVAILABLE_TALENT_COUNT_PREFS);
        }
        else
        {
            nAvailablePoints = 0;
        }
    }

    static void Save()
    {
        PlayerPrefs.SetInt(AVAILABLE_TALENT_COUNT_PREFS, nAvailablePoints);
    }

    private static int nAvailablePoints;
}
