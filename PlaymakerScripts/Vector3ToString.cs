using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.ScriptControl)]
    [Tooltip("Converts a Vector3 value to a String value.")]
    public class ConvertVector3ToString : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("Vector 3 variable to convert.")]
        public FsmVector3 v3Variable;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("A string variable to store the converted value.")]
        public FsmString stringVariable;

        [Tooltip("Repeat every frame. Useful if the string variable is changing.")]
        public bool everyFrame;

        public override void Reset()
        {
            v3Variable = null;
            stringVariable = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoConvertFloatToString();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoConvertFloatToString();
        }

        void DoConvertFloatToString()
        {
            stringVariable.Value = v3Variable.Value.ToString();

        }
    }
}