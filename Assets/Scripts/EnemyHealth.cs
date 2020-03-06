using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 3;
    public ParticleSystem effect;
    public GameObject deathSprite;

    private void Start()
    {
        effect = GetComponent<ParticleSystem>();

        enemyHealth = 3 + TimerScript.timer.time / 10;
    }

    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        effect.Play();
    }

    public bool WillEnemyDie()
    {
        if (enemyHealth <= 0)
        {
            Instantiate(deathSprite, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }
}
