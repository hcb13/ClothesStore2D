using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSellClothes : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField]
    private int price = 20;

    [Header("Dependencies")]
    [SerializeField]
    private ShowPlayerMoney showMoney;

    [SerializeField]
    private PlayerMoney playerMoney;

    [SerializeField]
    private Color colorInitialClothes;

    [SerializeField]
    private SpriteRenderer spriteClothes;

    public void SellClothes()
    {
        if (!Equals(colorInitialClothes, spriteClothes.color))
        {
            playerMoney.Sell(price);
            showMoney.UpdateTextMoney();
            spriteClothes.color = colorInitialClothes;
        }
        else
        {
            Debug.Log("Can't sell");
        }
    }

}
