// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Input)]
    [ActionTarget(typeof(GameObject), "GameObject")]
    [Tooltip("Sends Events based on mouse interactions with a Game Object: MouseOver, MouseDown, MouseUp, MouseOff. Use Ray Distance to set how close the camera must be to pick the object.\n\nNOTE: Picking uses the Main Camera.")]
    public class GetMousePickedObject : FsmStateAction
    {
        [CheckForComponent(typeof(Collider))]
        public FsmGameObject GameObject;

        [Tooltip("Length of the ray to cast from the camera.")]
        public FsmFloat rayDistance = 100f;

        [Tooltip("Event to send when the mouse is pressed while over the GameObject.")]
        public FsmEvent mouseDown;

        [Tooltip("Event to send when the mouse is released while over the GameObject.")]
        public FsmEvent mouseUp;

        [Tooltip("Pick only from these layers.")]
        [UIHint(UIHint.Layer)]
        public FsmInt[] layerMask;

        [Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
        public FsmBool invertMask;

        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            GameObject = null;
            rayDistance = 100f;
            mouseDown = null;
            mouseUp = null;
            layerMask = new FsmInt[0];
            invertMask = false;
            everyFrame = true;
        }

        public override void OnEnter()
        {
            DoMousePickEvent();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoMousePickEvent();
        }

        void DoMousePickEvent()
        {
            // Do the raycast

            if (Input.GetMouseButtonDown(0) )
            {
                RaycastHit hitInfo = ActionHelpers.MousePick(rayDistance.Value, ActionHelpers.LayerArrayToLayerMask(layerMask, invertMask.Value));


                // Store mouse pick info so it can be seen by Get Raycast Hit Info action

                Fsm.RaycastHitInfo = ActionHelpers.mousePickInfo;

                // Send events based on the raycast and mouse buttons

                if (hitInfo.transform != null)
                {
                    GameObject.Value = hitInfo.transform.gameObject;
                    if (Input.GetMouseButtonDown(0))
                    {
                        Fsm.Event(mouseDown);
                    }
                    if (Input.GetMouseButtonUp(0))
                    {
                        Fsm.Event(mouseUp);
                    }
                }
            }
        }
    }
}