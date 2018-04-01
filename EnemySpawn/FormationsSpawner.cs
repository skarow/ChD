using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public enum FigureType
{
    ePawn = 0,
    eBishop,
    eRook,
    // eBlackPawn,

}

public class FigureBlock
{
    public FigureBlock(FigureBlock other)
    {
        Row = other.Row;
        Type = other.Type;
    }
    public FigureBlock(int row, FigureType type)
    {
        Row = row;
        Type = type;
    }


    public int Row
    {
        get
        {
            return m_row;
        }

        set
        {
            m_row = value;
        }
    }
    internal FigureType Type
    {
        get
        {
            return m_type;
        }

        set
        {
            m_type = value;
        }
    }

    int m_row;
    FigureType m_type;
}

public class Formation
{
    public Formation()
    {
        blocks = new Dictionary<int, List<FigureBlock>>();
    }

    public int GetTotalBlocks()
    {
        int result = 0;
        foreach (var row in Blocks)
        {
            result += row.Value.Count;
        }
        return result;
    }

    public int GetMaxCols()
    {
        int result = 0;
        foreach (var row in Blocks)
        {
            foreach (var block in row.Value)
                if (block.Row > result)
                {
                    result = block.Row;
                }
        }
        return result;
    }
    public void SetOffset(int offset)
    {
        foreach (var pair in Blocks)
        {
            foreach (var block in pair.Value)
            {
                block.Row += offset - m_offset;
            }
        }
        m_offset = offset;
    }
    public int GetTotalRows()
    {
        return Blocks.Count;
    }
    public int Offset
    {
        get
        {
            return m_offset;
        }
    }

    internal Dictionary<int, List<FigureBlock>> Blocks
    {
        get
        {
            return blocks;
        }

        set
        {
            blocks = value;
        }
    }


    // private
    int m_offset;
    private Dictionary<int, List<FigureBlock>> blocks; // first is layer(col), second is row - all pawns in the formation

}



public static class FormationsSpawner
{
    const int ROW_1 = 0;
    const int ROW_2 = 1;
    const int ROW_3 = 2;
    const int ROW_4 = 3;
    const int ROW_5 = 4;

    static Dictionary<int, List<Formation>> formations; // first is difficuty level
    static List<Formation> m_selections;
    static int m_curRow;
    static int m_curFormation;

    static FormationsSpawner()
    {
        formations = new Dictionary<int, List<Formation>>();
        formations.Add(1, new List<Formation>());
        formations.Add(2, new List<Formation>());
        formations.Add(3, new List<Formation>());
        formations.Add(4, new List<Formation>());
        formations.Add(5, new List<Formation>());
        formations.Add(6, new List<Formation>());
        formations.Add(7, new List<Formation>());
        formations.Add(8, new List<Formation>());

        m_selections = new List<Formation>();
        InitFormations();

    }


    static void InitFormations()
    {
        FigureBlock col_1 = new FigureBlock(0, FigureType.ePawn);
        FigureBlock col_2 = new FigureBlock(1, FigureType.ePawn);
        FigureBlock col_3 = new FigureBlock(2, FigureType.ePawn);
        FigureBlock col_4 = new FigureBlock(3, FigureType.ePawn);
        FigureBlock col_5 = new FigureBlock(4, FigureType.ePawn);

        //FigureBlock col_1_bishop = new FigureBlock(0, FigureType.eBishop);
        //FigureBlock col_2_bishop = new FigureBlock(1, FigureType.eBishop);
        //FigureBlock col_3_bishop = new FigureBlock(2, FigureType.eBishop);
        //FigureBlock col_4_bishop = new FigureBlock(3, FigureType.eBishop);
        //FigureBlock col_5_bishop = new FigureBlock(4, FigureType.eBishop);

        //FigureBlock col_1_rook = new FigureBlock(0, FigureType.eRook);
        //FigureBlock col_2_rook = new FigureBlock(1, FigureType.eRook);
        //FigureBlock col_3_rook = new FigureBlock(2, FigureType.eRook);
        //FigureBlock col_4_rook = new FigureBlock(3, FigureType.eRook);
        //FigureBlock col_5_rook = new FigureBlock(4, FigureType.eRook);

        //1: 0----
        Formation f_1_0 = new Formation();
        {
            f_1_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            formations[1].Add(f_1_0);
        }

        //1: 00---
        Formation f_1_1 = new Formation();
        {
            f_1_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_1.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_1_1.Blocks[ROW_1].Add(new FigureBlock(col_2));
            formations[1].Add(f_1_1);
        }

        //1: 0-0--
        Formation f_1_2 = new Formation();
        {
            f_1_2.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_2.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_1_2.Blocks[ROW_1].Add(new FigureBlock(col_3));
            formations[1].Add(f_1_2);
        }

        //1: 0--0-
        Formation f_1_3 = new Formation();
        {
            f_1_3.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_3.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_1_3.Blocks[ROW_1].Add(new FigureBlock(col_4));
            formations[1].Add(f_1_3);
        }

        //1: 0---0
        Formation f_1_4 = new Formation();
        {
            f_1_4.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_4.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_1_4.Blocks[ROW_1].Add(new FigureBlock(col_5));
            formations[1].Add(f_1_4);
        }

        //2: 0----
        //1: 0----
        Formation f_1_5 = new Formation();
        {
            f_1_5.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_1_5.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_1_5.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_1_5.Blocks[ROW_2].Add(new FigureBlock(col_1));
            formations[1].Add(f_1_5);
        }

        //2: 0-0--
        //1: -0---
        Formation f_2_1 = new Formation();
        {
            f_2_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_1.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_1.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_2_1.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_2_1.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[2].Add(f_2_1);
        }

        //2: -0---
        //1: 0-0--
        Formation f_2_2 = new Formation();
        {
            f_2_2.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_2.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_2.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_2_2.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_2_2.Blocks[ROW_2].Add(new FigureBlock(col_2));
            formations[2].Add(f_2_2);
        }

        //2: 0----
        //1: --00-
        Formation f_2_3 = new Formation();
        {
            f_2_3.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_3.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_3.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_2_3.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_2_3.Blocks[ROW_2].Add(new FigureBlock(col_1));
            formations[2].Add(f_2_3);
        }

        //2: --0--
        //1: 00---
        Formation f_2_4 = new Formation();
        {
            f_2_4.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_4.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_4.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_2_4.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_2_4.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[2].Add(f_2_4);
        }

        //2: -00--
        //1: 0----
        Formation f_2_5 = new Formation();
        {
            f_2_5.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_5.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_5.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_2_5.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_2_5.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[2].Add(f_2_5);
        }

        //2: 00---
        //1: --0--
        Formation f_2_6 = new Formation();
        {
            f_2_6.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_2_6.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_2_6.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_2_6.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_2_6.Blocks[ROW_2].Add(new FigureBlock(col_2));
            formations[2].Add(f_2_6);
        }

        //3: -0---
        //2: 0-0--
        //1: -0---
        Formation f_3_0 = new Formation();
        {
            f_3_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_3_0.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_3_0.Blocks.Add(ROW_3, new List<FigureBlock>());
            f_3_0.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_3_0.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_3_0.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_3_0.Blocks[ROW_3].Add(new FigureBlock(col_2));
            formations[3].Add(f_3_0);
        }

        //2: 00---
        //1: 00---
        Formation f_4_0 = new Formation();
        {
            f_4_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_0.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_0.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_0.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_0.Blocks[ROW_2].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_0);
        }

        //2: 00---
        //1: 0-0--
        Formation f_4_1 = new Formation();
        {
            f_4_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_1.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_1.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_1.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_4_1.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_1.Blocks[ROW_2].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_1);
        }

        //2: -00--
        //1: 0-0--
        Formation f_4_2 = new Formation();
        {
            f_4_2.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_2.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_2.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_2.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_4_2.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_4_2.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[4].Add(f_4_2);
        }

        //2: 00---
        //1: -00--
        Formation f_4_3 = new Formation();
        {
            f_4_3.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_3.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_3.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_3.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_4_3.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_3.Blocks[ROW_2].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_3);
        }

        //2: -00--
        //1: 00---
        Formation f_4_4 = new Formation();
        {
            f_4_4.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_4.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_4.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_4.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_4.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_4_4.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[4].Add(f_4_4);
        }

        //2: 0-0--
        //1: 00---
        Formation f_4_5 = new Formation();
        {
            f_4_5.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_5.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_5.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_5.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_5.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_4_5.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[4].Add(f_4_5);
        }

        //2: 0-0--
        //1: -00--
        Formation f_4_6 = new Formation();
        {
            f_4_6.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_6.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_6.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_6.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_6.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_4_6.Blocks[ROW_2].Add(new FigureBlock(col_3));
            formations[4].Add(f_4_6);
        }

        //3: -0---
        //2: 0-0--
        //1: -00--
        Formation f_4_7 = new Formation();
        {
            f_4_7.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_7.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_7.Blocks.Add(ROW_3, new List<FigureBlock>());
            f_4_7.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_7.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_4_7.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_7.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_4_7.Blocks[ROW_3].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_7);
        }

        //3: -0---
        //2: 0-0--
        //1: 00---
        Formation f_4_8 = new Formation();
        {
            f_4_8.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_8.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_8.Blocks.Add(ROW_3, new List<FigureBlock>());
            f_4_8.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_4_8.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_8.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_8.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_4_8.Blocks[ROW_3].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_8);
        }

        //3: 00---
        //2: 0-0--
        //1: -0---
        Formation f_4_9 = new Formation();
        {
            f_4_9.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_9.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_9.Blocks.Add(ROW_3, new List<FigureBlock>());
            f_4_9.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_9.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_9.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_4_9.Blocks[ROW_3].Add(new FigureBlock(col_1));
            f_4_9.Blocks[ROW_3].Add(new FigureBlock(col_2));
            formations[4].Add(f_4_9);
        }

        //3: -00--
        //2: 0-0--
        //1: -0---
        Formation f_4_10 = new Formation();
        {
            f_4_10.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_4_10.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_4_10.Blocks.Add(ROW_3, new List<FigureBlock>());
            f_4_10.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_4_10.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_4_10.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_4_10.Blocks[ROW_3].Add(new FigureBlock(col_2));
            f_4_10.Blocks[ROW_3].Add(new FigureBlock(col_3));
            formations[4].Add(f_4_10);
        }

        //1: 1----
        Formation f_5_0 = new Formation();
        {
            f_5_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_5_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_5_0.Blocks[ROW_1][f_5_0.Blocks[ROW_1].Count - 1].Type = FigureType.eBishop;
            formations[5].Add(f_5_0);
        }

        //1: 2----
        Formation f_5_1 = new Formation();
        {
            f_5_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_5_1.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_5_1.Blocks[ROW_1][f_5_1.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            formations[5].Add(f_5_1);
        }

        //2: 0-0-0
        //1: -0-0-
        Formation f_5_2 = new Formation();
        {
            f_5_2.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_5_2.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_5_2.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_5_2.Blocks[ROW_1].Add(new FigureBlock(col_4));
            f_5_2.Blocks[ROW_2].Add(new FigureBlock(col_1));
            f_5_2.Blocks[ROW_2].Add(new FigureBlock(col_3));
            f_5_2.Blocks[ROW_2].Add(new FigureBlock(col_5));
            formations[5].Add(f_5_2);
        }

        //2: -0-0-
        //1: 0-0-0
        Formation f_5_3 = new Formation();
        {
            f_5_3.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_5_3.Blocks.Add(ROW_2, new List<FigureBlock>());
            f_5_3.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_5_3.Blocks[ROW_1].Add(new FigureBlock(col_3));
            f_5_3.Blocks[ROW_1].Add(new FigureBlock(col_5));
            f_5_3.Blocks[ROW_2].Add(new FigureBlock(col_2));
            f_5_3.Blocks[ROW_2].Add(new FigureBlock(col_4));
            formations[5].Add(f_5_3);
        }

        //1: 20---
        Formation f_6_0 = new Formation();
        {
            f_6_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_6_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_6_0.Blocks[ROW_1][f_6_0.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            f_6_0.Blocks[ROW_1].Add(new FigureBlock(col_2));
            formations[6].Add(f_6_0);
        }

        //1: 02---
        Formation f_6_1 = new Formation();
        {
            f_6_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_6_1.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_6_1.Blocks[ROW_1][f_6_1.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            f_6_1.Blocks[ROW_1].Add(new FigureBlock(col_1));
            formations[6].Add(f_6_1);
        }

        //1: 020--
        Formation f_7_0 = new Formation();
        {
            f_7_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_7_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_7_0.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_7_0.Blocks[ROW_1][f_7_0.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            f_7_0.Blocks[ROW_1].Add(new FigureBlock(col_3));
            formations[7].Add(f_7_0);
        }

        //1: 12---
        Formation f_8_0 = new Formation();
        {
            f_8_0.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_8_0.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_8_0.Blocks[ROW_1][f_8_0.Blocks[ROW_1].Count - 1].Type = FigureType.eBishop;
            f_8_0.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_8_0.Blocks[ROW_1][f_8_0.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            formations[8].Add(f_8_0);
        }

        //1: 21---
        Formation f_8_1 = new Formation();
        {
            f_8_1.Blocks.Add(ROW_1, new List<FigureBlock>());
            f_8_1.Blocks[ROW_1].Add(new FigureBlock(col_1));
            f_8_1.Blocks[ROW_1][f_8_1.Blocks[ROW_1].Count - 1].Type = FigureType.eRook;
            f_8_1.Blocks[ROW_1].Add(new FigureBlock(col_2));
            f_8_1.Blocks[ROW_1][f_8_1.Blocks[ROW_1].Count - 1].Type = FigureType.eBishop;
            formations[8].Add(f_8_1);
        }
    }

    public static int SelectForLevel(int level)
    {
        m_selections.Clear();

        int MAX_DIFFICULTY = 100;
        System.Random rnd = new System.Random(level);
        int totalEnemies = 0;

        int difficulty = 2 + level / 4;
        if (difficulty > MAX_DIFFICULTY)
            difficulty = MAX_DIFFICULTY;

        int maxLevel = 1 + (int)(Math.Log(level) / Math.Log(3));
        if (maxLevel > formations.Count)
        {
            maxLevel = formations.Count;
        }

        while (difficulty > maxLevel)
        {
            int randLevel = 1 + rnd.Next(maxLevel); // starts from 1
            int randFormation = rnd.Next(formations[randLevel].Count - 1);
            int formationMaxCols = formations[randLevel][randFormation].GetMaxCols();
            int randOffset = rnd.Next(4 - formationMaxCols);

            totalEnemies += formations[randLevel][randFormation].GetTotalBlocks();
            m_selections.Add(formations[randLevel][randFormation]);
            //m_selections[m_selections.Count - 1].SetOffset(0);// .Offset = randOffset;
            m_selections[m_selections.Count - 1].SetOffset(randOffset);

            //std::cout << "RandLevel: " << randLevel << " formation: " << randFormation << std::endl;

            difficulty -= maxLevel;
        }

        if (difficulty > 0)
        {
            int randFormation = rnd.Next(formations[difficulty].Count);
            int formationMaxCols = formations[difficulty][randFormation].GetMaxCols();
            int randOffset = rnd.Next(4 - formationMaxCols);

            totalEnemies += formations[difficulty][randFormation].GetTotalBlocks();
            m_selections.Add(formations[difficulty][randFormation]);
            m_selections[m_selections.Count - 1].SetOffset(randOffset);

            //std::cout << "RandLevel: " << difficulty << " formation: " << randFormation << std::endl;
        }
        m_curRow = 0;
        m_curFormation = 0;
        return totalEnemies;
    }

    public static List<FigureBlock> GetNextRow()
    {
        List<FigureBlock> result = new List<FigureBlock>();

        if (m_curFormation >= m_selections.Count)
            return result;

        if (m_curRow >= m_selections[m_curFormation].GetTotalRows())
        {
            m_curFormation++;
            m_curRow = 0;
        }

        if (m_curFormation >= m_selections.Count)
            return result;


        result = m_selections[m_curFormation].Blocks[m_curRow];
        m_curRow++;

        if (m_curRow > m_selections[m_curFormation].GetTotalRows())
        {
            m_curFormation++;
            m_curRow = 0;
        }
        return result;
    }
}
