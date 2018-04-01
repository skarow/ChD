using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("BoardActions")]
    public class  CheckIfInBoard: FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("The v3 variable to test.")]
        public FsmVector3 v3Variable;

        public Vector3 upLeftCorner;
        public Vector3 upRightCorner;
        public Vector3 downLeftCorner;
        public Vector3 downRightCorner;

        [Tooltip("Event to send if the Bool variable is True.")]
        public FsmEvent isTrue;

        [Tooltip("Event to send if the Bool variable is False.")]
        public FsmEvent isFalse;

        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;

        public override void Reset()
        {
            upLeftCorner = new Vector3();
            upRightCorner = new Vector3();
            downLeftCorner = new Vector3();
            downRightCorner = new Vector3();
            isTrue = null;
            isFalse = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            Fsm.Event(CheckIfInbound() ? isTrue : isFalse);

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            Fsm.Event(CheckIfInbound() ? isTrue : isFalse);
        }

        bool CheckIfInbound()
        {
            Vector3 var = v3Variable.Value;
            if (var.x < upLeftCorner.x || var.x > upRightCorner.x)
                return false;
            if (var.z < downLeftCorner.z || var.z > upLeftCorner.z)
                return false;

            return true;
        }

    }

}
