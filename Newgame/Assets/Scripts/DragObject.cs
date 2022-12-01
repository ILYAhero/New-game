using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }
    private void OnMouseDown()
    { if (gameManager.gameIsActive == true && transform.position.y > 2)
        { transform.position = new Vector3(transform.position.x, 20, transform.position.z);
            
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
         }
        
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    
    
    private void OnMouseDrag()
    {
        if (gameManager.gameIsActive == true && transform.position.y > 2)
            transform.position = GetMouseWorldPos();

        if (transform.position.x < -51)
        {
            transform.position = new Vector3(-51, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -12.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -12.5f);
        }

        if (transform.position.z > 12.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 12.5f);
        }


    }


    
}
