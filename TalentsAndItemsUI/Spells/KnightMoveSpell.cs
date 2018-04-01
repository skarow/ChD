using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Spells
{
    public class KnightMoveSpell : MonoBehaviour
    {
        public PickObject pickEnemyOrPlayer;

        public GameObject moveObject; // knight

        public void Activate(EPlayerSpells spell)
        {
            switch (spell)
            {
                case EPlayerSpells.eKnightMoveDown:
                    MoveDown();
                    break;
                case EPlayerSpells.eKnightMoveUp:
                    MoveUp();
                    break;
                case EPlayerSpells.eKnightMoveLeft:
                    MoveLeft();
                    break;
                case EPlayerSpells.eKnightMoveRight:
                    MoveRight();
                    break;
            }
        }


        void MoveUp()
        {
            Vector3 posUp = CalculatePosUp();
            if (CheckIfEmpty(posUp))
            {
                moveObject.transform.position = posUp;
            }
        }

        void MoveDown()
        {
            Vector3 posDown = CalculatePosDown();
            if (CheckIfEmpty(posDown))
            {
                moveObject.transform.position = posDown;
            }
        }

        void MoveLeft()
        {
            Vector3 posLeft = CalculatePosLeft();
            if (CheckIfEmpty(posLeft))
            {
                moveObject.transform.position = posLeft;
            }
        }

        void MoveRight()
        {
            Vector3 posRight = CalculatePosRight();
            if (CheckIfEmpty(posRight))
            {
                moveObject.transform.position = posRight;
            }
        }


        bool CheckIfEmpty(Vector3 position)
        {
            return !pickEnemyOrPlayer.CheckForObjectInPosition(position);
        }

        Vector3 CalculatePosUp()
        {
            Vector3 result = moveObject.transform.position;
            result.z += Board.Board.VERTICAL_MOVE;
            return result;
        }

        Vector3 CalculatePosDown()
        {
            Vector3 result = moveObject.transform.position;
            result.z -= Board.Board.VERTICAL_MOVE;
            return result;
        }

        Vector3 CalculatePosLeft()
        {
            Vector3 result = moveObject.transform.position;
            result.x -= Board.Board.HORIZONTAL_MOVE;
            return result;
        }

        Vector3 CalculatePosRight()
        {
            Vector3 result = moveObject.transform.position;
            result.x += Board.Board.HORIZONTAL_MOVE;
            return result;
        }
    }
}

