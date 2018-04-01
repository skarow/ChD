using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class SetMotivationalSplashes : MonoBehaviour {

    private TMP_Text m_text;
    Sequence mySequence;

    private void Awake()
    {
        mySequence = DOTween.Sequence();
        m_text = GetComponent<TextMeshProUGUI>();

        mySequence.Append(DOTween.To(x => m_text.alpha = x, 0, 1, .5f));
        mySequence.Append(DOTween.To(x => m_text.alpha = x, 1, 0, 3f));
        mySequence.OnComplete(DeactivateGameObject);
        mySequence.Rewind();

    }
    // Use this for initialization
    void Start () {
        
        m_text.alpha = 0;
        //Play();
    }

    public void Play()
    {
        mySequence.Rewind();
        mySequence.Play();
    }

    public void PlayNiceBlock()
    {
        m_text.SetText("<size=+60>N</size>ice <size=+60>B</size>lock");
        Play();
    }

    public void PlayGreatTake()
    {
        m_text.SetText("<size=+60>N</size>ice <size=+60>B</size>lock");
        Play();
    }

    public void PlayDoubleMove()
    {
        m_text.SetText("<size=+60>D</size>ouble<size=+60>M</size>ove");
        Play();
    }

    public void PlaySwitchPlayer()
    {
        m_text.SetText("<size=+60>S</size>witched<size=+60></size>");
        Play();
    }

    public void PlayEnemyTaken()
    {
        m_text.SetText("<size=+60>Y</size>ou <size=+60>G</size>ot <size=+60>H</size>im");
        Play();
    }

    public void PlayDoubleTake ()
    {
        m_text.SetText("<size=+60>D</size>ouble <size=+60>T</size>ake");
        Play();
    }

    public void PlayMotivationalText()
    {
        m_text.text = "Rock their world";
        Play();
    }

    void DeactivateGameObject()
    {
        mySequence.Rewind();
        //gameObject.SetActive(false);
    }
}
