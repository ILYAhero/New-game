using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProperties : MonoBehaviour
{


    private float xRange = 10.5f;
   

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -26.5f)
        {
            //transform.position = new Vector3(-29, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            //transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

      

        

        if (transform.position.z < -13)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, -14);
        }

        if (transform.position.z > 13)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, 14);
        }

    }
    
}
