using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentReach : MonoBehaviour
{

    public SpriteRenderer sprite;

    bool sE;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        sE = true;
    }
    private void OnMouseExit()
    {
        sE = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMoneyHandler.Instance.isBuying == true || sE == true)
        {
            sprite.enabled = true;
        }
        else
        {
            sprite.enabled = false;
        }
    }
}
