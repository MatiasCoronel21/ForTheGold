using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour {

    public TurretsAI turretAI;

    public bool isLeft = false;

    private void Awake()
    {
        turretAI = gameObject.GetComponentInParent<TurretsAI>();
    }

     void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (isLeft)
            {

                turretAI.Attack(false);
            }
            else
            {

                turretAI.Attack(true);
            }

        }
    }
}
