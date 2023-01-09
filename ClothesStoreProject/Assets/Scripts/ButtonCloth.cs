using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloth : MonoBehaviour
{

    [Header("Configuration")]
    [SerializeField]
    private Color clothColor;

    [SerializeField]
    private SpriteRenderer spriteCloth;

    [SerializeField]
    private int price = 20;

    [Header("Dependencies")]
    [SerializeField]
    private ShowPlayerMoney showMoney;

    [SerializeField]
    private PlayerMoney playerMoney;


    public void ChangeSpriteColor()
    {
        if (playerMoney.CheckPlayerCanBuy(price))
        {
            spriteCloth.color = clothColor;
            Buy();
        }
        else
        {
            Debug.Log("Can't buy");
        }
    }

    public void Buy()
    {
        playerMoney.Buy(price);
        showMoney.UpdateTextMoney();
    }

}
