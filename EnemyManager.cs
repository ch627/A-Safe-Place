using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform spawnPoint; // stores a refrence to the spawn point
    public GameObject enemyPrefab; // stores a refrence to the enemy prefab
    public bool stopSpawning = false;
    public float spawnTime = 1.0f;
    public float spawnDelay = 3.0f;

    private void Start()
    {
        StartCoroutine("SpawnDelay");
        //InvokeRepeating("SpawnNewEnemy", 1.0f, 3.0f);

    }

        void Spawn()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
    public IEnumerator SpawnDelay()
    {
        Spawn();
        yield return new WaitForSeconds(spawnDelay);
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
        

    }

}
