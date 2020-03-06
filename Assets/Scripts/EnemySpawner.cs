using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    Transform spawnerPosition;

    float spawnTimer = 0;
    public float spawnCooldown = 50;

    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnerPosition = GetComponent<Transform>();
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnerPosition.position, spawnerPosition.rotation);
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
