using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("uGui")]
    [Tooltip("Sets the color of a UGui Image component.")]
    public class uGuiImageSetColor : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(UnityEngine.UI.Image))]
        [Tooltip("The GameObject with the Image ui component.")]
        public FsmOwnerDefault gameObject;

        [RequiredField]
        [Tooltip("The source sprite of the UGui Image component.")]
        [ObjectType(typeof(UnityEngine.Color))]
        public FsmColor color;

        [Tooltip("Reset when exiting this state.")]
        public FsmBool resetOnExit;

        UnityEngine.UI.Image _image;


        public override void Reset()
        {
            gameObject = null;
            resetOnExit = false;
        }

        public override void OnEnter()
        {
            GameObject _go = Fsm.GetOwnerDefaultTarget(gameObject);
            if (_go != null)
            {
                _image = _go.GetComponent<UnityEngine.UI.Image>();
            }

            DoSetImageSourceValue();

            Finish();
        }

        void DoSetImageSourceValue()
        {
            if (_image == null)
            {
                return;
            }

            _image.color = (UnityEngine.Color)color.Value;
        }

        public override void OnExit()
        {
            if (_image == null)
            {
                return;
            }
        }

    }
}