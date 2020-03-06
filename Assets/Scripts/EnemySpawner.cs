using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform spawnerPosition1;
    public Transform spawnerPosition2;
    int spawnNumber;

    float spawnTimer = 0;
    public float spawnCooldown = 50;

    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //spawnerPosition = GetComponent<Transform>();
        spawnNumber = 0;
    }

    void SpawnEnemy()
    {
        if (spawnNumber % 2 == 0)
        {
            Instantiate(enemyPrefab, spawnerPosition1.position, spawnerPosition1.rotation);
        }
        else
        {
            Instantiate(enemyPrefab, spawnerPosition2.position, spawnerPosition2.rotation);
        }
        spawnNumber += 1;
        //Instantiate(enemyPrefab, spawnerPosition.position, spawnerPosition.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer++;
        if (spawnTimer >= spawnCooldown)
        {
            SpawnEnemy();
            spawnTimer = 0;
        }
    }
}
