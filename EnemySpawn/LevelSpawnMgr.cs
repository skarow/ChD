using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnMgr : MonoBehaviour {

    //public PlayMakerArrayListProxy enemyArray;

    private const int PAWNS = 0;
    private const int BISHOPS = 1;
    private const int ROOKS = 2;

    public GameObject enemyPos;
    private PlayMakerArrayListProxy[] enemyArrays;


    private List<Vector3[]> levelsPawns;
    private List<Vector3[]> levelsBishops;
    private List<Vector3[]> levelsRooks;
	
    // Use this for initialization
	void Start () {
        // defs
        enemyArrays = enemyPos.GetComponents<PlayMakerArrayListProxy>();

        levelsPawns = new List<Vector3[]>();
        levelsBishops = new List<Vector3[]>();
        levelsRooks = new List<Vector3[]>();


        // level 0
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl0);
        //levelsBishops.Add(LevelEnemyDefenitions.bishopsPosLvl0);
        //levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvl0);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 1
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl1);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 2
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl2);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        
        // level 3
        //levels.Add(LevelEnemyDefenitions.pawnsPosLvl3);
        //levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        //levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        
        // level 4
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl4);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 5
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl5);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 6
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl6);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 7
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl7);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 8
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl8);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 9
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl9);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 10
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl10);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 11
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl11);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 12
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl12);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        
        // level 13
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl13);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 14
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl14);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 15
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl15);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 16
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl16);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 17
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl17);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 18
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl18);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 19
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl19);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 20
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl20);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 21
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl21);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 22
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl22);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 23
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl23);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 24
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl24);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 25
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl25);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 26
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl26);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);

        // level 27
        levelsPawns.Add(LevelEnemyDefenitions.pawnsPosLvl27);
        levelsBishops.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);
        levelsRooks.Add(LevelEnemyDefenitions.rooksPosLvlEmpty);


    }

    public void GetEnemyPositions(int level)
    {
        GetPawnsPositions(level);
        GetBishopsPositions(level);
        GetRooksPositions(level);
    }

    private void  GetPawnsPositions(int level)
    {
        if (level >= levelsPawns.Count)
        {
            return;
        }
        enemyArrays[PAWNS].arrayList.Clear();
        for (int i = 0; i < levelsPawns[level].Length; ++i)
        {
            enemyArrays[PAWNS].arrayList.Add(levelsPawns[level][i]);
        }
    }

    private void GetBishopsPositions(int level)
    {
        if (level >= levelsBishops.Count)
        {
            return;
        }
        enemyArrays[BISHOPS].arrayList.Clear();
        for (int i = 0; i < levelsBishops[level].Length; ++i)
        {
            enemyArrays[BISHOPS].arrayList.Add(levelsBishops[level][i]);
        }
    }

    private void GetRooksPositions(int level)
    {
        if (level >= levelsRooks.Count)
        {
            return;
        }
        enemyArrays[ROOKS].arrayList.Clear();
        for (int i = 0; i < levelsRooks[level].Length; ++i)
        {
            enemyArrays[ROOKS].arrayList.Add(levelsRooks[level][i]);
        }
    }
}
