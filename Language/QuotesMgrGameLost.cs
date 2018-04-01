using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuotesMgrGameLost : MonoBehaviour {

    private List<string> quotes;

    private void Awake()
    {
        quotes = new List<string>()
        {
            "Arrrh, come on man. You can do eeeet",
            "Is that all you've got?",
            "Toughen up!",
            "Gonna cry to mama?",
            "Suck it up, Buttercup!",
            "Big boys and girls don't cry. Why are you?",
            "Fall 8 times get up 9",
            "Life is hard so games are hard",
        };
    }

    public string GetRandomQuote()
    {
        int index = UnityEngine.Random.Range(0, quotes.Count);
        return quotes[index];
    }

}
