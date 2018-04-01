using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Spells
{
    public class BishopPickEnemySpells : MonoBehaviour
    {
        public PickObject enemyPick;

        EPlayerSpells m_playerSpell;

        bool bActivated;
        GameObject touchedObject;
        // Use this for initialization
        void Awake()
        {
            bActivated = false;
        }

        public void Activate( EPlayerSpells spell )
        {
            bActivated = true;
            m_playerSpell = spell;
        }

        // Update is called once per frame
        void Update()
        {
            if (!bActivated) return;

            if (Camera.main == null)
            {
                Debug.Log("No MainCamera defined!");
                return;
            }

            touchedObject = enemyPick.GetTouchedObject();

            if (touchedObject == null)
            {
                return;
            }

            switch ( m_playerSpell )
            {
                case EPlayerSpells.eBishopWithholdEnemy:
                    BishopWithholdEnemySpell.Activate(touchedObject);
                    break;
                case EPlayerSpells.eBishopEntangle:
                case EPlayerSpells.eBishopFreeze: // as an upgrade to root/entangle
                    BishopRootSpell.Activate(touchedObject);
                    break;
                case EPlayerSpells.eBishopInstantDeath:
                    BishopInstantDeathSpell.Activate(touchedObject);
                    break;
            }
            bActivated = false;

        }
    }

}
