using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Transform bullet;
    public Transform target;
    public GameObject turrent;

    public float bulletDamage = 1;
    public float bulletSpeed = 5;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(bulletDamage);
            if (collision.GetComponent<EnemyHealth>().WillEnemyDie() == true)
            {
                target = null;
                PlayerMoneyHandler.Instance.AddCash(100);

                if (bullet.tag == "ExplosiveBullet")
                {
                    bullet.GetComponent<Bullet2Script>().PlayExplosion();
                }
            }
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if (target != null)
        {
            bullet.transform.position = Vector2.MoveTowards(bullet.position, target.position, bulletSpeed * Time.deltaTime);
            //bullet.LookAt(target);
        }
        else
        {
            Destroy(this.gameObject);
            turrent.GetComponent<TurrentTargeting>().hasATarget = false;
        }

    }
}
