using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.ScriptControl)]
    [Tooltip("Gets a random qoute from quotes list in a script.")]
    public class GetRandomQoute : FsmStateAction
    {

        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("Script variable ask for quote.")]
        public QuotesMgr quoteMgr;
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("string variable to store.")]
        public FsmString stringQuoteText;

        public override void Reset()
        {
            quoteMgr = null;
            stringQuoteText = null;
        }

        public override void OnEnter()
        {
            stringQuoteText.Value = quoteMgr.GetRandomQuote();
        }
    }
}