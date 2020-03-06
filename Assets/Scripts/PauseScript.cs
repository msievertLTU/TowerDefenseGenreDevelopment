using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;

    void Start ()
    {
        isPaused = false;
    }

    public void PauseGame()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    
    void Update()
    {
       if (Input.GetAxis("escape") != 0)
        {
            PauseGame();
        }
    }
}
