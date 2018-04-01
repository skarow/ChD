using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMainMultilangResources : MonoBehaviour {

    /// Panel UI
    public Text buttonSettings;
    public Text buttonMyBook;
    public Text buttonMyFight;
    public Text buttonGenerator;

    private string hintTextBg = "Спри враговете преди да стигнат до лагера ти(най-долната част). Внимавай, че могат да те атакуват по диагонал(само напред). Ако някоя от фигурите ти е точно пред някой противник - той спира да се движи. Текущата фигура е оцветена в синьо. Натисни жълтото поле, за да се придвижиш. Късмет!";
    private string hintTextEn = "Stop the enemies from reaching your camp(the bottom). Beware as they can attack you diagnoly(forward only). If one of your figures is directly in front of one of the enemies - it stops moving. Current figure is highlighted in blue.Move by clicking on a yellow field. Good luck!";

    /// Panel Main
    // GameWonPanel
    public Text gwWinText;
    public Text gwTapToContinue;
    // GameLostPanel
    public Text glTextLost;
    public Text glTapToContinue;
    // Panels/HintPanel
    public Text hintText;

    // Panel Settings
    public Text settingsLanguage;
    public Text skin;
    public Text skinNormal;
    public Text skinHigh;
    public Text hint;
    public Text hintHide;

    // Panel The story
    public Text title;
    // the other chapter title is set in SetChapterText.cs
    public Text chapter1;
    public Text chapter2;
    public Text chapter3;
    public Text chapter4;
    public Text chapter5;
    public Text chapter6;
    public Text chapter7;
    public Text chapter8;
    public Text chapter9;
    public Text chapter10;
    public Text chapter11;
    public Text chapter12;
    public Text chapter13;
    public Text chapter14;
    public Text chapter15;
    public Text chapter16;
    public Text chapter17;
    public Text chapter18;
    public Text chapter19;
    public Text chapter20;
    public Text chapter21;
    public Text chapter22;
    public Text chapter23;
    public Text chapter24;
    public Text chapter25;
    public Text chapter26;
    public Text chapter27;
    public Text chapter28;

    // Use this for initialization
    void Start()
    {
        SetResourcesText();
    }

    public void SetResourcesText()
    {
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                // Panel UI
                buttonSettings.text = "Настройки";
                buttonMyBook.text = "Книга";
                buttonMyFight.text = "Битка";
                buttonGenerator.text = "Създай";
                /// Panel Main
                // GameWonPanel
                gwWinText.text = "Битката спечелена!";
                gwTapToContinue.text = "Продължи";
                // GameLostPanel
                glTextLost.text = "Битката изгубена";
                glTapToContinue.text = "Продължи";
                // Panels/HintPanel
                hintText.text = hintTextBg;
                // Panel Settings
                settingsLanguage.text = "Език";
                skin.text = "Скин";
                skinNormal.text = "Нормален";
                skinHigh.text = "Екстра";
                hint.text = "Подсказки";
                hintHide.text = "Скриване";
                // Panel The story
                title.text = "Том I";
                SetChaptersTextBg();
                break;
            case LanguageMgr.LANGUAGE_EN:
                // Panel UI
                buttonSettings.text = "Settings";
                buttonMyBook.text = "My Book";
                buttonMyFight.text = "Fight";
                buttonGenerator.text = "Generate";
                /// Panel Main
                // GameWonPanel
                gwWinText.text = "Battle Won!";
                gwTapToContinue.text = "Tap to continue";
                // GameLostPanel
                glTextLost.text = "Battle Lost";
                glTapToContinue.text = "Tap to continue";
                // Panels/HintPanel
                hintText.text = hintTextEn;
                // Panel Settings
                settingsLanguage.text = "Language";
                skin.text = "Skin";
                skinNormal.text = "Normal";
                skinHigh.text = "High";
                hint.text = "Hints:";
                hintHide.text = "Hide";
                // Panel The story
                title.text = "Act I";
                SetChaptersTextEn();
                break;
            default:
                // Panel UI
                buttonSettings.text = "Settings";
                buttonMyBook.text = "My Book";
                buttonMyFight.text = "Fight";
                buttonGenerator.text = "Generate";
                /// Panel Main
                // GameWonPanel
                gwWinText.text = "Battle Won!";
                gwTapToContinue.text = "Tap to continue";
                // GameLostPanel
                glTextLost.text = "Battle Lost";
                glTapToContinue.text = "Tap to continue";
                // Panels/HintPanel
                hintText.text = hintTextEn;
                // Panel Settings
                settingsLanguage.text = "Language";
                skin.text = "Skin";
                skinNormal.text = "Normal";
                skinHigh.text = "High";
                hint.text = "Hints:";
                hintHide.text = "Hide";
                // Panel The story
                title.text = "Act I";
                SetChaptersTextEn();
                break;
        }
    }

    private void SetChaptersTextBg()
    {
        chapter1.text = "Глава 1";
        chapter2.text = "Глава 2";
        chapter3.text = "Глава 3";
        chapter4.text = "Глава 4";
        chapter5.text = "Глава 5";
        chapter6.text = "Глава 6";
        chapter7.text = "Глава 7";
        chapter8.text = "Глава 8";
        chapter9.text = "Глава 9";
        chapter10.text = "Глава 10";
        chapter11.text = "Глава 11";
        chapter12.text = "Глава 12";
        chapter13.text = "Глава 13";
        chapter14.text = "Глава 14";
        chapter15.text = "Глава 15";
        chapter16.text = "Глава 16";
        chapter17.text = "Глава 17";
        chapter18.text = "Глава 18";
        chapter19.text = "Глава 19";
        chapter20.text = "Глава 20";
        chapter21.text = "Глава 21";
        chapter22.text = "Глава 22";
        chapter23.text = "Глава 23";
        chapter24.text = "Глава 24";
        chapter25.text = "Глава 25";
        chapter26.text = "Глава 26";
        chapter27.text = "Глава 27";
        chapter28.text = "Глава 28";;
    }

    private void SetChaptersTextEn()
    {
        chapter1.text = "Chapter 1";
        chapter2.text = "Chapter 2";
        chapter3.text = "Chapter 3";
        chapter4.text = "Chapter 4";
        chapter5.text = "Chapter 5";
        chapter6.text = "Chapter 6";
        chapter7.text = "Chapter 7";
        chapter8.text = "Chapter 8";
        chapter9.text = "Chapter 9";
        chapter10.text = "Chapter 10";
        chapter11.text = "Chapter 11";
        chapter12.text = "Chapter 12";
        chapter13.text = "Chapter 13";
        chapter14.text = "Chapter 14";
        chapter15.text = "Chapter 15";
        chapter16.text = "Chapter 16";
        chapter17.text = "Chapter 17";
        chapter18.text = "Chapter 18";
        chapter19.text = "Chapter 19";
        chapter20.text = "Chapter 20";
        chapter21.text = "Chapter 21";
        chapter22.text = "Chapter 22";
        chapter23.text = "Chapter 23";
        chapter24.text = "Chapter 24";
        chapter25.text = "Chapter 25";
        chapter26.text = "Chapter 26";
        chapter27.text = "Chapter 27";
        chapter28.text = "Chapter 28";
    }
}
