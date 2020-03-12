using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISoundScript : MonoBehaviour
{
    public static UISoundScript Instance;
    AudioSource source;
    public AudioClip uiSound;

    void Start()
    {
        Instance = this;
        source = GetComponent<AudioSource>();
        source.clip = uiSound;
    }

    public void PlayUISound()
    {
        source.Play();
    }
}
