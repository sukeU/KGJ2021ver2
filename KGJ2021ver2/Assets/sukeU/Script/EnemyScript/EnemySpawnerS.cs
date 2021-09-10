using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerS : MonoBehaviour
{
    [Serializable]
    public class  EnemyState
    {
        public Enemy enemy;
        public RouteS route;
        public float appearTime;
    }
    [Serializable]
    public class WaveManager
    {
        public List<EnemyState> enemystates;
    }

    public WaveManager[] waveManagers;
    public int waveCount;
    public float time;

    private void Update()
    {
        waveCount = 0;
        time += Time.deltaTime;
        
    }

    public void CreateEN()
    {
        foreach(var enemystates in waveManagers[waveCount].enemystates)
        {
            if (enemystates.appearTime <= time)
            {
                var enemy = Instantiate(enemystates.enemy, new Vector3(100, 100), Quaternion.identity);
                enemy.RouteS = enemystates.route;
            }
        }
        //waveManagers[waveCount].enemystates.RemoveAll()
    }
}