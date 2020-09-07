using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

     

    private void OnTriggerEnter2D(Collider2D col)
    {
     
            if (col.tag == "Player")
            {
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
                GameObject personaje = GameObject.Find("Personaje");
                personaje.SetActive(false);
                 }else{
            Destroy(gameObject, 2f);

        }


      

         
    }
}
