using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioSprite : MonoBehaviour {

    public Sprite spriteInvicibilidad;

    public SpriteRenderer personajeCambiable;



    public void Invencibilidad()
    {

        personajeCambiable.sprite = spriteInvicibilidad;
    }
}
