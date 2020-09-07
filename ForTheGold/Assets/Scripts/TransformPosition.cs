using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public Transform[] waypunto;
    private int index;
    public float velocidad;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (waypunto[index].position != transform.position)

        {
          
            transform.position = Vector3.MoveTowards(transform.position, waypunto[index].position, velocidad * Time.deltaTime);

        }
        else
        {
            if (index < waypunto.Length - 1)
            {

                index++;
            }
            else
            {
                Shuffle();
                index = 0;
            }
           
        }
        
    }

    void Shuffle ()
    {
        Transform tmp;
        for (int i = 0; i < waypunto.Length; i++)
        {
            tmp = waypunto[i];
            int r = Random.Range(i, waypunto.Length);
            waypunto[i] = waypunto[r];
            waypunto[r] = tmp;
        }


    }
}
