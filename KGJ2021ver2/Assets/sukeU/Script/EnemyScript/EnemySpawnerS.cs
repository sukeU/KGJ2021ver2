using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerS : MonoBehaviour
{
    private ConfigS ConfigS;
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

    private void Start()
    {
        ConfigS = GameObject.Find("Config").GetComponent<ConfigS>();
    }

    private void Update()
    {
        waveCount = 0;
        if (ConfigS.handOver == false)
        {
            time += Time.deltaTime;
            CreateEN();
        }
    }

    public void CreateEN()
    {
        foreach(var enemystate in waveManagers[waveCount].enemystates)
        {
            if (enemystate.appearTime <= time)
            {
                var enemy = Instantiate(enemystate.enemy, new Vector3(100, 100), Quaternion.identity);
                enemy.RouteS = enemystate.route;
            }
        }
        waveManagers[waveCount].enemystates.RemoveAll(enemystate => enemystate.appearTime <= time);
    }
}