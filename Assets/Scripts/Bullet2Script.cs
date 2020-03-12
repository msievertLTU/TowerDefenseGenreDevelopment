using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2Script : MonoBehaviour
{
    AudioSource source;
    public AudioClip[] explosionSounds;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayExplosion()
    {
        source.clip = explosionSounds[Random.Range(0, explosionSounds.Length)];
        source.Play();
    }
}
