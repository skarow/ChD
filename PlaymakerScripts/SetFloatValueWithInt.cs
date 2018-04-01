using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Sets the value of a Float Variable.")]
    public class SetFloatValueWithInt : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmFloat floatVariable;
        [RequiredField]
        public FsmInt intValue;
        public bool everyFrame;

        public override void Reset()
        {
            floatVariable = null;
            intValue = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            floatVariable.Value = intValue.Value;

            if (!everyFrame)
                Finish();
        }

        public override void OnUpdate()
        {
            floatVariable.Value = intValue.Value;
        }
    }
}