using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class ShowPlayerMoney : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField]
    private PlayerMoney playerMoney;

    [SerializeField]
    private TMPro.TextMeshProUGUI textMoney;

    private void Start()
    {
        UpdateTextMoney();
    }


    public void UpdateTextMoney()
    {
        textMoney.text = playerMoney.Money.ToString();
    }

}
