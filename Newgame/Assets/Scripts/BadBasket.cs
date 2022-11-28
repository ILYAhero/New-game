using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBasket : MonoBehaviour
{
    
    private bool hasEntered;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Main Camera").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {

      

        if (collision.gameObject.tag == "Good")

        {
            collision.gameObject.tag = "Wrong";
            gameManager.lives -= 1;
            if (gameManager.lives == 0)
            {
                gameManager.gameIsActive = false;
            }
        }
    }
}
