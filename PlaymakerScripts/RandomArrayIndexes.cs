using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{

    [ActionCategory("Formation Spawner")]
    [Tooltip("Sets formation spawner level")]
    public class SetFormationSpawnLevel : FsmStateAction
    {
        [RequiredField]
        public FsmInt level;

        [Tooltip("how many enemies will be spawned")]
        [UIHint(UIHint.Variable)]
        public FsmInt totalEnemiesToSpawn;

        public override void Reset()
        {
            level = null;
        }

        public override void OnEnter()
        {
            totalEnemiesToSpawn.Value = FormationsSpawner.SelectForLevel(level.Value);
            Finish();
        }
    }

    [ActionCategory("Formation Spawner")]
    [Tooltip("Fills arrays with formation spawner information")]
    public class RandomFormationSpawn : FsmStateAction
    {
        public PlayMakerArrayListProxy resultIndexes;
        public PlayMakerArrayListProxy resultTypes;

        public override void Reset()
        {
            resultTypes = null;
            resultIndexes = null;
        }

        public override void OnEnter()
        {
            resultTypes.arrayList.Clear();
            resultIndexes.arrayList.Clear();
            PickNext();
            Finish();
        }
        void PickNext()
        {
            List<FigureBlock> blocks = FormationsSpawner.GetNextRow();
            foreach ( var block in blocks )
            {
                resultIndexes.arrayList.Add(block.Row);
                resultTypes.arrayList.Add(block.Type);
            }
        }
    }

    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Sets an Integer Variable to a random value between Min/Max.")]
    public class RandomArrayIndexes : FsmStateAction
    {
        public FsmBool noRepeat;

        [RequiredField]
        public FsmInt indexesCount;

        public PlayMakerArrayListProxy array;
        public PlayMakerArrayListProxy resultIndexes;

        private ArrayList indexes;


        public override void Reset()
        {
            array = null;
            resultIndexes = null;
            noRepeat = false;
            indexes.Clear();
        }

        public override void OnEnter()
        {
            indexes = new ArrayList();
            resultIndexes.arrayList.Clear();
            PickRandom();
            Finish();
        }

        void PickRandom()
        {
            for (int i = 0; i < array.arrayList.Count; i++)
            {
                indexes.Add(i);
            }

            int addedElements = 0;

            while (addedElements < indexesCount.Value)
            {
                if (noRepeat.Value)
                {
                    if (indexes.Count == 0) break;
                    int randomIndex = Random.Range(0, indexes.Count);
                    resultIndexes.arrayList.Add(indexes[randomIndex]);
                    indexes.Remove(indexes[randomIndex]);
                }
                else
                {
                    int randomIndex = Random.Range(0, array.arrayList.Count);
                    resultIndexes.arrayList.Add(randomIndex);
                }
                addedElements++;
            };
        }
    }
}
