﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInvencibilidad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "Player")
        {
            print(collider.gameObject.name);
            collider.gameObject.GetComponent<CambioSprite>().Invencibilidad();

        }
    }
}
