using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLifeTimer : MonoBehaviour
{
    public float TowerTimer = 30f;

    void Update()
    {
        TowerTimer -= Time.deltaTime;
        if (TowerTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
