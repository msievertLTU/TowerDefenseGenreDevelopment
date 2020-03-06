using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource soundeffectSource;
    public AudioClip soundeffect1;

    void Awake()
    {
        backgroundMusic.mute = false;
    }

    public void ToggleMusic()
    {
        backgroundMusic.mute = !backgroundMusic.mute;
    }

    public void PlaySound()
    {
        soundeffectSource.PlayOneShot(soundeffect1);
        Color randColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
    }
}