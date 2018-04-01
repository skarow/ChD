using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetInitMultilangResources : MonoBehaviour {

    public Text welcomeSign;
    public Text loadingSign;



    // Use this for initialization
    void Start ()
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                welcomeSign.text = "Добре дошли!";
                loadingSign.text = "Продължи";
                break;
            case LanguageMgr.LANGUAGE_EN:
                welcomeSign.text = "Welcome!";
                loadingSign.text = "Tap to continue";
                break;
            default:
                welcomeSign.text = "Welcome!";
                loadingSign.text = "Tap to continue";
                break;
        }
    }
}
