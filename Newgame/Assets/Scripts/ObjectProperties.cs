using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProperties : MonoBehaviour
{


    private float xRange = 13;
   

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -28)
        {
            transform.position = new Vector3(-28, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -xRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -xRange);
        }

        if (transform.position.z > xRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, xRange);
        }

    }
    
}
