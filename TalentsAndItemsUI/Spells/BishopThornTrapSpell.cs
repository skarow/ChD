using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spells
{
    public class BishopThornTrapSpell : MonoBehaviour
    {

        const int TRAP_DURATION = 4;
        public PickObject pickBoardField;
        public PickObject pickEnemyOrFriend;

        GameObject touchedField;
        int m_nDuratation = 0;
        bool m_bActivated = false;

        Talent trapTalent;
        private void Start()
        {
            trapTalent = TalentsHolderMgr.GetTalent(EPlayerSpells.eBishopThornTrap);
        }

        public void Activate()
        {
            m_bActivated = true;
        }

        private void Update()
        {
            if (!m_bActivated) return;

            if (Camera.main == null)
            {
                Debug.Log("No MainCamera defined!");
                return;
            }

            touchedField = pickBoardField.GetTouchedObject();

            if (touchedField == null) return;

            m_nDuratation = TRAP_DURATION;
            FxMgr.Instance.ActivateTrapFX(touchedField.transform.position);
            m_bActivated = false;
        }

        public void Tick()
        {
            if (m_nDuratation > 0)
            {
                m_nDuratation--;
                GameObject objectAbove = pickEnemyOrFriend.GetObjectInPosition(touchedField.transform.position);
                if (objectAbove != null)
                {
                    int killChance = trapTalent.GetBonusPercentage();
                    var rollDice = Random.Range(0, 100);
                    if (rollDice < killChance) // kill
                        BishopInstantDeathSpell.Activate(objectAbove);
                }
            }

            if (m_nDuratation == 0)
            {
                FxMgr.Instance.DeactivateTrapFX();
            }
        }

        public void ClearThornTrap()
        {
            m_nDuratation = 0;
            FxMgr.Instance.DeactivateTrapFX();
        }
    }
} // namespace
