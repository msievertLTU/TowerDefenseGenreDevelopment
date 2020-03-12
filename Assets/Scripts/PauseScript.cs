using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseUI;
    float coolDown = 1f;

    void Start ()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    void ChangeActive(bool act)
    {
        pauseUI.SetActive(act);
        //for (int i = 0; i < pauseUI.Length; i++)
        //{
        //    pauseUI[i].SetActive(act);
        //}
    }

    public void PauseGame()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            ChangeActive(true);
        }
        else
        {
            Time.timeScale = 1;
            ChangeActive(false);
        }
    }

    void Update()
    {
        coolDown -= Time.deltaTime;

        if (Input.GetAxis("escape") != 0 && coolDown <= 0)
        {
            PauseGame();
            coolDown = 1f;
        }
    }
}
