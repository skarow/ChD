using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spells
{
    public class BishopPushEnemySpell : MonoBehaviour
    {

        public PickObject pickEnemyOrPlayer;

        EPlayerSpells m_playerSpell;
        bool bActivated = false;
        GameObject touchedObject;

        public void Activate(EPlayerSpells spell)
        {
            bActivated = true;
            m_playerSpell = spell;
        }

        private void Update()
        {
            if (!bActivated) return;
            if (Camera.main == null)
            {
                Debug.Log("No MainCamera defined!");
                return;
            }

            touchedObject = pickEnemyOrPlayer.GetTouchedObject();
            if (touchedObject == null) return;

            switch (m_playerSpell)
            {
                case EPlayerSpells.eBishopPushDown:
                    PushDown();
                    break;
                case EPlayerSpells.eBishopPushUp:
                    PushUp();
                    break;
                case EPlayerSpells.eBishopPushLeft:
                    PushLeft();
                    break;
                case EPlayerSpells.eBishopPushRight:
                    PushRight();
                    break;
            }
            bActivated = false;
        }

        void PushUp()
        {
            Vector3 posUp = CalculatePosUp();
            if (CheckIfEmpty(posUp))
            {
                touchedObject.transform.position = posUp;
            }
        }

        void PushDown()
        {
            Vector3 posDown = CalculatePosDown();
            if (CheckIfEmpty(posDown))
            {
                touchedObject.transform.position = posDown;
            }
        }

        void PushLeft()
        {
            Vector3 posLeft = CalculatePosLeft();
            if (CheckIfEmpty(posLeft))
            {
                touchedObject.transform.position = posLeft;
            }
        }

        void PushRight()
        {
            Vector3 posRight = CalculatePosRight();
            if (CheckIfEmpty(posRight))
            {
                touchedObject.transform.position = posRight;
            }
        }


        bool CheckIfEmpty(Vector3 position)
        {
            return !pickEnemyOrPlayer.CheckForObjectInPosition(position);
        }

        Vector3 CalculatePosUp()
        {
            Vector3 result = touchedObject.transform.position;
            result.z += Board.Board.VERTICAL_MOVE;
            return result;
        }

        Vector3 CalculatePosDown()
        {
            Vector3 result = touchedObject.transform.position;
            result.z -= Board.Board.VERTICAL_MOVE;
            return result;
        }

        Vector3 CalculatePosLeft()
        {
            Vector3 result = touchedObject.transform.position;
            result.x -= Board.Board.HORIZONTAL_MOVE;
            return result;
        }

        Vector3 CalculatePosRight()
        {
            Vector3 result = touchedObject.transform.position;
            result.x += Board.Board.HORIZONTAL_MOVE;
            return result;
        }
    }
}

