using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField]
    private int money = 20;
    public int Money
    {
        get { return money; }
    }

    public void Sell(int price)
    {
        money += price;
    }

    public void Buy(int price)
    {
        money -= price;
    }

    public bool CheckPlayerCanBuy(int price)
    {
        return (money - price) >= 0;
    }

}
