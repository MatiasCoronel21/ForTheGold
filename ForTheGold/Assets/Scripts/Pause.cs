using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public static bool  isPaused = false;
    

    void OnMouseDown()
    {

        pauseGame();
        GetComponent<AudioSource>().Play();
    }

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }else
        {

            Time.timeScale = 0;
            isPaused = true;
        }
    } 


}
