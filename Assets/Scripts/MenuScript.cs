using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartHowTo()
    {
        SceneManager.LoadScene("HowTo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
