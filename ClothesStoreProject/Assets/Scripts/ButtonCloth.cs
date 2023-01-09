using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloth : MonoBehaviour
{

    [Header("Color")]
    [SerializeField]
    private Color clothColor;

    [Header("Cloth")]
    [SerializeField]
    private SpriteRenderer spriteCloth;

    
    public void ChangeSpriteColor()
    {
        spriteCloth.color = clothColor;
    }


}
