using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    public IntData enemyCount;
    public GameObject enemyObj;

    public void Start()
    {
        //Invoke(@"SpawnEnemy");
    }

    public void Update()
    {
        if (enemyCount.value >= 6)
        {
            
        }
    }
}
