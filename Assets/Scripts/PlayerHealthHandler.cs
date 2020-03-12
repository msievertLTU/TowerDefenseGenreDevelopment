using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthHandler : MonoBehaviour
{
    public static PlayerHealthHandler Instance;
    public Text healthText;
    public int health;

    void Start()
    {
        Instance = this;
        health = 5;
        healthText.text = health.ToString();
    }

    void TakeDamage(int dmg)
    {
        health -= dmg;
        healthText.text = health.ToString();
    }

    void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            TakeDamage(1);
            Destroy(collision);
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            EndGame();
        }
    }
}
