using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Class Wrapper")]
    [Tooltip("Wraps Items class in Chess Defender and equips an new item to slot 1. ")]
    public class ItemEquip1 : FsmStateAction
    {
        [Tooltip("Which item")]
        public FsmEnum item;

        public override void OnEnter()
        {
            Items.Equip1((EItem)item.Value);
            Finish();
        }
    }

    [ActionCategory("Class Wrapper")]
    [Tooltip("Wraps Items class in Chess Defender and Uses spell in slot 1. ")]
    public class ItemUse1 : FsmStateAction
    {
        public override void OnEnter()
        {
            Items.UseCurrentItem1();
            Finish();
        }
    }

    [ActionCategory("Class Wrapper")]
    [Tooltip("Wraps Items class in Chess Defender and Every time the game starts - reequip. ")]
    public class EquipCurrent1 : FsmStateAction
    {
        public override void OnEnter()
        {
            Items.UseCurrentItem1();
            Finish();
        }
    }

    [ActionCategory("Class Wrapper")]
    [Tooltip("Wraps Items class in Chess Defender and equips an new item to slot 1. ")]
    public class ItemGetEquipped1 : FsmStateAction
    {
        [Tooltip("Which item")]
        [UIHint(UIHint.Variable)]
        public FsmEnum item;

        public override void OnEnter()
        {
            item.Value = Items.GetEquipped1();
            Finish();
        }
    }
}
