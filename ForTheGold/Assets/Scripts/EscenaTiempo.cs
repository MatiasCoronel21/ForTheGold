using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaTiempo : MonoBehaviour {

    public float tiempo_start; //Segundos al comenzar
    public float tiempo_end;//Segundos para que cambie

    public string nombreEscenaParaCargar = "EscenaIntro";

    void Update()
    {
        tiempo_start += Time.deltaTime;
        if (tiempo_start >= tiempo_end) 
        {
            Application.LoadLevel(nombreEscenaParaCargar);
        }
    }
  
}

