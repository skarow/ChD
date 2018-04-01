using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Sets the value of material object.")]
    public class SetMaterialVarMaterial : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        public FsmMaterial MaterialValue;
        [RequiredField]
        public Material material;
        public bool everyFrame;

        public override void Reset()
        {
            MaterialValue = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            MaterialValue.Value = material;

            if (!everyFrame)
                Finish();
        }

        public override void OnUpdate()
        {
            MaterialValue.Value = material;
        }
    }
}