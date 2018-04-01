// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using System;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Sets the value of an Integer Variable.")]
    public class IntLogarithm : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmInt intVariable;
        [RequiredField]
        public FsmInt logBase;
        [RequiredField]
        public FsmInt storeVar;
        public bool everyFrame;

        public override void Reset()
        {
            intVariable = null;
            logBase = null;
            storeVar = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            storeVar.Value = (int)Math.Log(intVariable.Value, logBase.Value);

            if (!everyFrame)
                Finish();
        }

        public override void OnUpdate()
        {
            storeVar.Value = (int)Math.Log(intVariable.Value, logBase.Value);
        }
    }
}