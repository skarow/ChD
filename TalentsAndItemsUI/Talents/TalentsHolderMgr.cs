using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public enum EPlayerSpells
{
    eNone,
    eKnightMoveLeft,
    eKnightMoveRight,
    eKnightMoveUp,
    eKnightMoveDown,
    eKnightSwiftJustice,
    eKnightInnerStrength, // double move
    eKnightInnerStrengthEnhanced,      // Triple move chance
    eKnightSoulLink,      // Switch Player
    eKnightRebirth,
    eKnightMastery,
    eKnightCutTies,
    eKnightSpellsCount,
    eBishopPushUp,
    eBishopPushDown,
    eBishopPushLeft,
    eBishopPushRight,
    eBishopThornTrap,
    eBishopClearTrap,
    eBishopWithholdEnemy,
    eBishopEntangle,
    eBishopFreeze,
    eBishopInstantDeath,
    eBishopMastery,
    eBishopCutTies,
    eCount
}

public static class TalentsHolderMgr  {

    static Dictionary<EPlayerSpells, Talent> talents;

    // Use this for initialization
    static TalentsHolderMgr() {
        //Instance = this;

        talents = new Dictionary<EPlayerSpells, Talent>
        {
            {
                EPlayerSpells.eKnightMoveLeft,
                new Talent
                {
                    Name = "kMoveLeft",
                    Title = "Wind Move Left",
                    Desc = "Grants the knight the ability to move left by one square",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },

            // new talent
            {
                EPlayerSpells.eKnightMoveRight,
                new Talent
                {
                    Name = "kMoveRight",
                    Title = "Wind Move Right",
                    Desc = "Grants the knight the ability to move right by one square",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },

            //new Talent
            {
                EPlayerSpells.eKnightMoveUp,
                new Talent
                {
                    Name = "kMoveUp",
                    Title = "Wind Move Up",
                    Desc = "Grants the knight the ability to move up by one square",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },

            //new Talent
            {
                EPlayerSpells.eKnightMoveDown,
                new Talent
                {
                    Name = "kMoveDown",
                    Title = "Wind Move Down",
                    Desc = "Grants the knight the ability to move down by one square",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
             //new Talent
            {
                EPlayerSpells.eKnightSwiftJustice,
                new Talent
                {
                    Name = "kSwiftJustice",
                    Title = "Swift Justice",
                    Desc = "With this ability the knight attacks and returns at starting position in one swift move.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
             //new Talent
            {
                EPlayerSpells.eKnightInnerStrength,
                new Talent
                {
                    Name = "kInnerStrength",
                    Title = "Inner Strength",
                    Desc = "Call upon every musle, bone and sinel and move twice instead of once.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
             //new Talent
            {
                EPlayerSpells.eKnightInnerStrengthEnhanced,
                new Talent
                {
                    Name = "kInnerStrengthEnhanced",
                    Title = "Inner Strength Enhanced",
                    Desc = "Grants you a chance for triple move every time inner strength is called upon.",
                    MaxTalentLevel = 2,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 0),   // level 1 %
                        new CooldownPenalty(20, 0),   // level 2 %
                        new CooldownPenalty(30, 0),   // level 3 %
                        new CooldownPenalty(40, 0),   // level 40 %
                    },
                }
            },

            //new Talent
            {
                EPlayerSpells.eKnightSoulLink,
                new Talent
                {
                    Name = "kSoulLink",
                    Title = "Soul Link",
                    Desc = "Asks the bishop to act first and reduces bishop's penalty for casting to 0.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 0),   // level 1
                        new CooldownPenalty(8, 0),    // level 2
                        new CooldownPenalty(6, 0),    // level 3
                        new CooldownPenalty(5, 0),    // level 4
                    },
                }
            },

             //new Talent
            {
                EPlayerSpells.eKnightCutTies,
                new Talent
                {
                    Name = "kCutTies",
                    Title = "Cut Ties",
                    Desc = "Your use of magic affects much less you and the bishop. Reduces all global cooldowns by 1.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(0, 0),    // level 1
                        new CooldownPenalty(0, 0),    // level 1
                        new CooldownPenalty(0, 0),    // level 1
                    },
                }
            },

            {
                EPlayerSpells.eKnightMastery,
                new Talent
                {
                    Name = "kMastery",
                    Title = "Mastery",
                    Desc = "You are far more capable than before. Decreases all local cooldowns by 1.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(0, 0),    // level 1
                        new CooldownPenalty(0, 0),    // level 1
                        new CooldownPenalty(0, 0),    // level 1
                    },
                }
            },
            //new Talent
            {
                EPlayerSpells.eKnightRebirth,
                new Talent
                {
                    Name = "kRebirth",
                    Title = "Rebirht",
                    Desc = "When the knight dies there is a chance that he'll respawn at starting position.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(50,  0),   // level 1
                        new CooldownPenalty(75,  0),   // level 2
                        new CooldownPenalty(100, 0),   // level 3
                        new CooldownPenalty(100, 0),   // level 4
                    },
                }
            },

            //    new Talent
            {
                EPlayerSpells.eBishopPushDown,
                new Talent
                {
                    Name = "bPushDown",
                    Title = "Holy Force Down",
                    Desc = "Bishop calls upon holy forces to push an enemy back.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopPushUp,
                new Talent
                {
                    Name = "bPushUp",
                    Title = "Holy Force Up",
                    Desc = "Bishop calls upon holy forces to push an enemy forth.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopPushLeft,
                new Talent
                {
                    Name = "bPushLeft",
                    Title = "Holy Force Left",
                    Desc = "Bishop calls upon holy forces to push an enemy left.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopPushRight,
                new Talent
                {
                    Name = "bPushRight",
                    Title = "Holy Force Right",
                    Desc = "Bishop calls upon holy forces to push an enemy right.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopThornTrap,
                new Talent
                {
                    Name = "bThornTrap",
                    Title = "Summon Thorn Trap",
                    Desc = "Summons a thorn trap on a field with a chance to entice anything that gets there.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopClearTrap,
                new Talent
                {
                    Name = "bClearTrap",
                    Title = "Clear Trap",
                    Desc = "Clears the summoned trap.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(10, 4),  // level 1
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopWithholdEnemy,
                new Talent
                {
                    Name = "bWithholdEnemy",
                    Title = "WithholdEnemy",
                    Desc = "Renders an enemy unable to attack.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopEntangle,
                new Talent
                {
                    Name = "bEntangle",
                    Title = "Entangle",
                    Desc = "Stops an enemy making him unable to move forward. Beware as he can still attack!",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },

            //    new Talent
            {
                EPlayerSpells.eBishopInstantDeath,
                new Talent
                {
                    Name = "bInstantDeath",
                    Title = "Instant Death",
                    Desc = "You smite an enemy with vicious strength causing an instant kill.",
                    MaxTalentLevel = 4,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                        new CooldownPenalty(6, 2),   // level 3
                        new CooldownPenalty(5, 1),   // level 4
                        new CooldownPenalty(4, 1),   // level 5
                        new CooldownPenalty(3, 1),   // level 6
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopMastery,
                new Talent
                {
                    Name = "bMastery",
                    Title = "Mastery",
                    Desc = "You are far more capable than before. Reduces all local cooldowns by 1.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopCutTies,
                new Talent
                {
                    Name = "bCutTies",
                    Title = "Cut Ties",
                    Desc = "Your use of magic affects much less the you and the knight. Reduces all global cooldowns by 1.",
                    MaxTalentLevel = 1,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(10, 4),  // level 1
                        new CooldownPenalty(8, 3),   // level 2
                    },
                }
            },
            //    new Talent
            {
                EPlayerSpells.eBishopFreeze,
                new Talent
                {
                    Name = "bFreeze",
                    Title = "Freeze",
                    Desc = "When you use Entangle there is a chance to freeze the enemy.",
                    MaxTalentLevel = 2,
                    levelDef = new List<CooldownPenalty>
                    {
                        new CooldownPenalty(-1, -1),  // level 0
                        new CooldownPenalty(50,   0),  // level 1
                        new CooldownPenalty(75,  0),   // level 2
                        new CooldownPenalty(100, 0),   // level 3
                    },
                }
            },
        };

        LoadTalents();
    }

    #region Public Methods
    // sets local and global cooldown
    static public void UseSpell(EPlayerSpells spell)
    {
        Talent talent = talents[spell];
        talent.CurrentPenalty = talent.levelDef[talent.UpgradedTalentLevel].localCooldown;
        SetGlobalCooldown(talent.levelDef[talent.UpgradedTalentLevel].globalCooldown);
    }

    // decreases penalty
    static public void DecreasePenalty()
    {
        foreach (var talent in talents)
        {
            talent.Value.DecreasePenalty();
        }
    }

    // get total points for availability of talents
    static public int TotalKnightPoints()
    {
        int result = 0;
        foreach ( var talent in talents )
        {
            if ( talent.Key < EPlayerSpells.eKnightSpellsCount )
            {
                result += talent.Value.TalentLevel;
            }
        }
        return result;
    }
    static public int TotalBishopPoints()
    {
        int result = 0;
        foreach (var talent in talents)
        {
            if ( talent.Key > EPlayerSpells.eKnightSpellsCount )
            {
                result += talent.Value.TalentLevel;
            }
        }
        return result;
    }

    // used in Start()
    static void LoadTalents()
    {
        foreach (var talent in talents)
        {
            talent.Value.Load();
        }
    }

    // used in UseSpell
    static void SetGlobalCooldown(int penalty)
    {
        foreach (var talent in talents)
        {
            if (talent.Value.CurrentPenalty < penalty)
            {
                talent.Value.CurrentPenalty = penalty;
            }
        }
    }


    static public void ResetKnightTalents()
    {
        foreach (var talent in talents)
        {
            if ( talent.Key < EPlayerSpells.eKnightSpellsCount )
            {
                talent.Value.TalentLevel = 0;
                talent.Value.UpgradedTalentLevel = 0;
            }
        }
    }
    static public void ResetBishopTalents()
    {
        foreach (var talent in talents)
        {
            if ( talent.Key > EPlayerSpells.eKnightSpellsCount )
            {
                talent.Value.TalentLevel = 0;
                talent.Value.UpgradedTalentLevel = 0;
            }
        }
    }
    static public void SaveAll()
    {
        foreach (var talent in talents)
        {
            talent.Value.Save();
        }
    }


    #endregion

    #region Item Upgrades

    static public void UpgradeSpell(EPlayerSpells spell, int level )
    {
        talents[spell].UpgradedTalentLevel += level;
    }

    static public void DowngradeSpell(EPlayerSpells spell, int level)
    {
        talents[spell].UpgradedTalentLevel -= level;
    }

    #endregion

    #region Talents Get Increase Decrease

    static public Talent GetTalent( EPlayerSpells spell )
    {
        return talents[spell];
    }
    #endregion // Talents Get Increase Decrease


}
