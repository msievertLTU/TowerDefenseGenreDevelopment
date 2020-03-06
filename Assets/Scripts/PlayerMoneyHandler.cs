using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoneyHandler : MonoBehaviour
{
    public static PlayerMoneyHandler Instance;
    public float money = 1000;
    float tempMoney;

    public bool isBuying;

    public Text moneyText;

    void Start()
    {
        Instance = this;
        isBuying = false;
    }

    public void AddCash(float amount)
    {
        money += amount;
    }

    public void RemoveCash(float amount)
    {
        money -= amount;
    }

    public bool HasEnoughCash(float amount)
    {
        if ((tempMoney - amount) >= 0)
        {
            isBuying = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        moneyText.text = "$ " + money;
        tempMoney = money;

        if (isBuying == true)
        {
            if (Input.GetMouseButtonDown(0) && isBuying == true)
            {
                isBuying = false;
            }
        }

    }
}
