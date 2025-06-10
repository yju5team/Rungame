using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    public void SpawnEnemy()
    {
        var Enemy = EnemyPool.GetObject();
        Enemy.transform.position = transform.position;
    }
}
