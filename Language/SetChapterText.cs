using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class SetChapterText : MonoBehaviour {

    public Text title;
    public Text text;
    StoryChaptersMgr chapterMgr;
    private int currentChapter;

    private FsmInt currMaxChapter;
    private FsmInt gCurrentSelectedLevel;
    private const int ABSOLUTE_MAX_CHAPTER = 26;


    private void Awake()
    {
        currentChapter = 0;
        chapterMgr = new StoryChaptersMgr();
        currMaxChapter = FsmVariables.GlobalVariables.GetFsmInt("gCurrentLevel _int");
        gCurrentSelectedLevel = FsmVariables.GlobalVariables.GetFsmInt("gCurrentSelectedLevel");
    }

    public void SetText(int chapterNo)
    {
        text.text = (chapterMgr.GetChapterText(chapterNo));
        currentChapter = chapterNo;
        gCurrentSelectedLevel.Value = chapterNo;
        switch (LanguageMgr.currentLanguage)
        {
            case LanguageMgr.LANGUAGE_BG:
                title.text = "Глава " + (chapterNo + 1);
                break;
            case LanguageMgr.LANGUAGE_EN:
                title.text = "Chapter " + (chapterNo + 1);
                break;
            default:
                title.text = "Chapter " + (chapterNo + 1);
                break;
        }
        
    }

    public void SetPrevChapter()
    {
        --currentChapter;
        if (currentChapter < 0)
            currentChapter++;
        
        SetText(currentChapter);
    }

    public void SetNextChapter()
    {
        ++currentChapter;
        if (currentChapter >= chapterMgr.GetSize() || currentChapter > currMaxChapter.Value)
            currentChapter--;
        SetText(currentChapter);
    }
        
}

