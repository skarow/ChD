using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EItem
{
    eNone,
    eMoveLeftScroll,
    eMoveRightScroll,
    eMoveUpScroll,
    eMoveDownScroll,
    eInnerStrengthScroll,
    eSoulLinkScroll,
}

public static class Items
{
    const string EQUIPPED1_KEY = "ItemEquipped1";
    static Items()
    {
        if ( PlayerPrefs.HasKey(EQUIPPED1_KEY) )
        {
            int curEquipped = PlayerPrefs.GetInt(EQUIPPED1_KEY);
            equipped1 = (EItem)curEquipped;
        }
        else
        {
            equipped1 = EItem.eNone;
        }
        allItems = new Dictionary<EItem, Item>
        {
            { EItem.eMoveLeftScroll,        new BonusMoveLeftScroll()       },
            { EItem.eMoveRightScroll,       new BonusMoveRightScroll()      },
            { EItem.eMoveUpScroll,          new BonusMoveUpScroll()         },
            { EItem.eMoveDownScroll,        new BonusMoveDownScroll()       },
            { EItem.eInnerStrengthScroll,   new BonusInnerStrenghtScroll()  },
            { EItem.eSoulLinkScroll,        new BonusSoulLinkScroll()       },
        };
    }
    public static void EquipCurrent1 ()
    {
        allItems[equipped1].Equip();
    }
    // deequips current and equips the new one
    public static void Equip1 ( EItem item )
    {
        if ( equipped1 != EItem.eNone )
        {
            allItems[equipped1].Deequip();
        }
        equipped1 = item;
        allItems[equipped1].Equip();
        PlayerPrefs.SetInt( EQUIPPED1_KEY, (int)equipped1 );
        PlayerPrefs.Save();
    }
    public static EItem GetEquipped1()
    {
        return equipped1;
    }
    public static void UseCurrentItem1()
    {
        if (equipped1 != EItem.eNone)
            allItems[equipped1].Use();
    }

    static EItem equipped1;
    static Dictionary<EItem, Item> allItems;
}

public abstract class Item {

    public abstract void Equip();
    public abstract void Deequip();
    public abstract void Use();
}

public class BonusMoveLeftScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightMoveLeft, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightMoveLeft, 1);
    }
    public override void Use() { }

}

public class BonusMoveRightScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightMoveRight, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightMoveRight, 1);
    }
    public override void Use() { }
}

public class BonusMoveDownScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightMoveDown, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightMoveDown, 1);
    }
    public override void Use() { }
}

public class BonusMoveUpScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightMoveUp, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightMoveUp, 1);
    }
    public override void Use() { }
}

public class BonusInnerStrenghtScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightInnerStrength, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightInnerStrength, 1);
    }
    public override void Use() { }
}

public class BonusSoulLinkScroll : Item
{
    public override void Equip()
    {
        TalentsHolderMgr.UpgradeSpell(EPlayerSpells.eKnightSoulLink, 1);
    }
    public override void Deequip()
    {
        TalentsHolderMgr.DowngradeSpell(EPlayerSpells.eKnightSoulLink, 1);
    }
    public override void Use() { }
}
