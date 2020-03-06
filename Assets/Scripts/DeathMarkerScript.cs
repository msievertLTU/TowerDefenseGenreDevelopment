using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMarkerScript : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer sRender;

    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();
        sRender.sprite = sprites[Random.Range(0,sprites.Length)];

        Destroy(this.gameObject, 10);
    }
}
