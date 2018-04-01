using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageMgr : MonoBehaviour {

    const string languageKey = "language";
    [HideInInspector]
    public const int LANGUAGE_EN = 0;
    [HideInInspector]
    public const int LANGUAGE_BG = 1;

    public static int currentLanguage;

	// Use this for initialization
	void Awake () {

        DontDestroyOnLoad(this);

        if ( PlayerPrefs.HasKey(languageKey) )
        {
            currentLanguage = PlayerPrefs.GetInt(languageKey);
        }
        else // set english as default
        {
            currentLanguage = LANGUAGE_EN;
            PlayerPrefs.SetInt(languageKey, LANGUAGE_EN);
        }
	}

    public void SetBulgarian ()
    {
        currentLanguage = LANGUAGE_BG;
        Save();
    }

    public void SetEnglish ()
    {
        currentLanguage = LANGUAGE_EN;
        Save();
    }

    public void Save ()
    {
        PlayerPrefs.SetInt(languageKey, currentLanguage);
    }
}
