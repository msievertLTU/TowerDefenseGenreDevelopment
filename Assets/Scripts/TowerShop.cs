using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerShop : MonoBehaviour
{
    public Canvas ShopCanvas;

    public GameObject Turren1Prefab;
    public float Tower1Cost = 250;

    public GameObject Turrent2Prefab;
    public float Tower2Cost = 500;

    public GameObject Turrent3Prefab;
    public float Tower3Cost = 1000;

    private void Awake()
    {
        ShopCanvas.enabled = false;
    }

    public void BuyTurrent1()
    {
        if (PlayerMoneyHandler.Instance.HasEnoughCash(Tower1Cost) == true)
        {
            PlayerMoneyHandler.Instance.RemoveCash(Tower1Cost);
            CloseShopGUI();
            GameObject turrent = Instantiate(Turren1Prefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
    }

    public void BuyTurrent2()
    {
        if (PlayerMoneyHandler.Instance.HasEnoughCash(Tower2Cost) == true)
        {
            PlayerMoneyHandler.Instance.RemoveCash(Tower2Cost);
            CloseShopGUI();
            GameObject turrent = Instantiate(Turrent2Prefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
    }

    public void BuyTurrent3()
    {
        if (PlayerMoneyHandler.Instance.HasEnoughCash(Tower3Cost) == true)
        {
            PlayerMoneyHandler.Instance.RemoveCash(Tower3Cost);
            CloseShopGUI();
            GameObject turrent = Instantiate(Turrent3Prefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
    }

    public void OpenShopGUI()
    {
        ShopCanvas.enabled = true;
    }

    public void CloseShopGUI()
    {
        ShopCanvas.enabled = false;
    }
   
}
