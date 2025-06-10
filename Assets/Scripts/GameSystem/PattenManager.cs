using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PattenManager : MonoBehaviour
{
    public List<SpawnPosition> spawnPoint;
    public float coolTime;
    public float oneCan;

    void Start()
    {
        StartCoroutine(SpawnEnemyPattern());
    }

    IEnumerator SpawnEnemyPattern()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int randnum = Random.Range(1, 13); // 1
            StartCoroutine(SpawnEnemy(randnum));
        }
    }

    IEnumerator SpawnEnemy(int pattenNum)
    {
        int[][] spawnPattern;

        switch (pattenNum)
        {
            case 1:
                spawnPattern = new int[][]
                {
                new int[] { 4 },
                new int[] { 3, 5 },
                new int[] { 2 },
                new int[] { 1, 7 },
                new int[] { 0, 8 },
                new int[] { 1, 7 },
                new int[] { 6 },
                new int[] { 3, 5 },
                new int[] { 4 }
                };
                break;

            case 2:
                spawnPattern = new int[][]
                {
                new int[] { 4 },
                new int[] { 3, 5 },
                new int[] { 2, 6 },
                new int[] { 1, 7 },
                new int[] { 0, 8 }
                };
                break;

            case 3:
                spawnPattern = new int[][]
                {
                new int[] { 0, 8 },
                new int[] { 1, 7 },
                new int[] { 2, 6 },
                new int[] { 3, 5 },
                new int[] { 4 }
                };
                break;

            case 4:
                spawnPattern = new int[][]
                {
                new int[] { 0, 8 },
                new int[] { 1, 7 },
                new int[] { 2, 6 },
                new int[] { 3, 5 },
                new int[] { 4 },
                new int[] { 3, 5 },
                new int[] { 2, 6 },
                new int[] { 1, 7 },
                new int[] { 0, 8 }
                };
                break;

            case 5:
                spawnPattern = new int[][]
                {
                new int[] { 0 },
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { 5 },
                new int[] { 6 },
                new int[] { 7 },
                new int[] { 8 },
                new int[] { 7 },
                new int[] { 6 },
                new int[] { 5 },
                new int[] { 4 },
                new int[] { 3 },
                new int[] { 2 },
                new int[] { 1 },
                new int[] { 0 }
                };
                break;
            case 6:
                spawnPattern = new int[][]
                {
                new int[] { 8 },
                new int[] { 7 },
                new int[] { 6 },
                new int[] { 5 },
                new int[] { 4 },
                new int[] { 3 },
                new int[] { 2 },
                new int[] { 1 },
                new int[] { 0 },
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { 5 },
                new int[] { 6 },
                new int[] { 7 },
                new int[] { 8 }
                };
                break;

            case 7:
                spawnPattern = new int[][]
                {
                new int[] { 6,7,8 },
                new int[] { 3,4,5 },
                new int[] { 0,1,2 },
                new int[] { 3,4,5 },
                new int[] { 6,7,8 },
                new int[] { 3,4,5 },
                new int[] { 0,1,2 },
                new int[] { 3,4,5 },
                new int[] { 6,7,8 }
                };
                break;
            case 8:
                spawnPattern = new int[][]
                {
                new int[] { 0,1,2 },
                new int[] { 3,4,5 },
                new int[] { 6,7,8 },
                new int[] { 3,4,5 },
                new int[] { 0,1,2 },
                new int[] { 3,4,5 },
                new int[] { 6,7,8 },
                new int[] { 3,4,5 },
                new int[] { 0,1,2 }
                };
                break;

            case 9:
                spawnPattern = new int[][]
                {
                new int[] { 0,1,2,3,4,5,6,7,8 },
                new int[] { 0,8 },
                new int[] { 0,8 },
                new int[] { 0,8 },
                new int[] { 0,8 },
                new int[] { 0,8 },
                new int[] { 0,8 },
                new int[] { 0,1,2,3,4,5,6,7,8 }
                };
                break;

            case 10:
                spawnPattern = new int[][]
                {
                new int[] { 0,4,8 },
                new int[] { 0,2,4,6,8 },
                new int[] { 0,2,4,6,8 },
                new int[] { 0,2,4,6,8 },
                new int[] { 2 },
                new int[] { 5 },
                new int[] { 1,5,7 },
                new int[] { 1, 3, 5, 7 },
                new int[] { 1,3,7 },
                new int[] { 3,7 },
                new int[] {0,5,8 },
                new int[] { 0, 2, 5, 8 },
                new int[] { 0,2,5,8 },
                new int[] { 0,2,5 }
                };
                break;

            case 11:
                spawnPattern = new int[][]
                {
                new int[] { 1,7 },
                new int[] { 0,3,6 },
                new int[] { 2,5,8 },
                new int[] { 1,4,7 },
                new int[] {  },
                new int[] { 5 },
                new int[] { 1,4,7 },
                new int[] { 0,3,6},
                new int[] { 2,5,8 },
                new int[] { 3,7 },
                new int[] { 0,6 }
                };
                break;

            case 12:
                spawnPattern = new int[][]
                {
                new int[] { 0,2,3,4,5,8 },
                new int[] {  },
                new int[] { 4,5,7 },
                new int[] {  },
                new int[] { 0,1,2 },
                new int[] {  },
                new int[] { 6,7 },
                new int[] {  },
                new int[] { 1,2,3,4 },
                new int[] {  },
                new int[] { 8 },
                new int[] {  },
                new int[] { 5,6},
                new int[] {  },
                new int[] { 0,1,2,3,8 }
                };
                break;

            default:
                yield break;
        }

        yield return StartCoroutine(SpawnPattern(spawnPattern));
    }

    IEnumerator SpawnPattern(int[][] spawnPattern)
    {
        foreach (var spawnGroup in spawnPattern)
        {
            foreach (int index in spawnGroup)
            {
                spawnPoint[index].SpawnEnemy();
            }
            yield return new WaitForSeconds(oneCan);
        }
    }

}
