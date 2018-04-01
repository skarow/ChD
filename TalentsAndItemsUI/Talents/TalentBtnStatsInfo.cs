using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalentBtnStatsInfo : MonoBehaviour {

    Color colorInactive = new Color(214f / 255f, 207f / 255f, 156f / 255f); // gold
    Color colorActive = Color.green;
    Color colorEnchanced = new Color(.361f, 1f, .945f);

    Text textStatInfo;

    // Use this for initialization
    void Awake () {
        textStatInfo = GetComponent<Text>();
        textStatInfo.color = colorInactive;
    }
    public void SetInactive()
    {
        if (textStatInfo == null ) { return;  }
        textStatInfo.color = colorInactive;
    }

    public void SetActive()
    {
        if (textStatInfo == null) { return; }
        textStatInfo.color = colorActive;
    }

    public void SetCurrentAndMaxValues( int currentValue, int maxValue)
    {
        if (textStatInfo == null) { return; }
        textStatInfo.text = currentValue + "/" + maxValue;
        if (currentValue > maxValue )
        {
            textStatInfo.color = colorEnchanced;
        }
    }
}
