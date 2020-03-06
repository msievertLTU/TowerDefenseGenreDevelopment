using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentTargeting : MonoBehaviour
{
    public Transform turrent;
    public bool hasATarget;
    public Transform target;

    SpriteRenderer turrentSprite;
    public SpriteRenderer reach;

    public bool CanPlace;
    public bool IsPlaced;

    void Start()
    {
        turrent = GetComponent<Transform>();
        turrentSprite = turrent.gameObject.GetComponent<SpriteRenderer>();
        hasATarget = false;
        IsPlaced = false;
        CanPlace = true;

        turrentSprite.color = new Color(255, 255, 255, 255);
    }

    public void OnMouseEnter()
    {
        reach.enabled = true;
    }
    public void OnMouseExit()
    {
        reach.enabled = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (hasATarget != true && collision.tag == "Enemy")
        {
            target = collision.transform;
            if (target != null)
            {
                hasATarget = true;
            }
            else
            {
                hasATarget = false;
            }

        }
        if (collision.tag == "MapCollider")
        {
            CanPlace = false;
            turrentSprite.color = new Color(255, 0, 0, 255);
        }
        if (collision.tag == "Tower")
        {
            CanPlace = false;
            turrentSprite.color = new Color(255, 0, 0, 255);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            hasATarget = false;
        }
        if (collision.tag == "MapCollider")
        {
            CanPlace = true;
            turrentSprite.color = new Color(255, 255, 255, 255);
        }
        if (collision.tag == "Tower")
        {
            CanPlace = true;
            turrentSprite.color = new Color(255, 255, 255, 255);
        }

    }

    void Update()
    {
        if (IsPlaced == false)
        {
            turrent.GetComponent<CircleCollider2D>().radius = 0.3f;
        }
        else
        {
            turrent.GetComponent<CircleCollider2D>().radius = 1.8f;
            turrentSprite.color = new Color(255, 255, 255, 255);
        }

        if (hasATarget == true && target != null)
        {
            turrent.up = -(turrent.transform.position - target.transform.position);
        }

        if (IsPlaced == false)
        {
            turrent.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            turrent.position = new Vector3(turrent.position.x, turrent.position.y, 0);
            if (Input.GetMouseButtonDown(0) && CanPlace == true)
            {
                IsPlaced = true;
                turrent.GetComponent<TurrentShooting>().IsPlaced = true;
                turrent.position = new Vector3(turrent.position.x, turrent.position.y, 0);
            }
        }
    }
}
