using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    public Transform target;
    public float enemySpeed = 1;
    Transform enemy;

    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    void Update()
    {
        enemy.transform.position = Vector2.MoveTowards(enemy.position, target.position, enemySpeed * Time.deltaTime / 5);

        if (enemy.transform.position == target.transform.position)
        {
                target = target.GetComponent<TradeTarget>().nextTarget;
        }
    }
}
