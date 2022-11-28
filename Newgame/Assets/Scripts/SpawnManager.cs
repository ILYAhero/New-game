using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public List<GameObject> GoodObjects;
    public List<GameObject> BadObjects;



    private float spawnRangeX = 14;
    private float spawnPosY = 2.5f;
    private float spawnRangeZ = 14;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            int GoodObjectsIndex = Random.Range(0, GoodObjects.Count);
            Vector3 spawnPosGood = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(GoodObjects[GoodObjectsIndex], spawnPosGood, GoodObjects[GoodObjectsIndex].transform.rotation);
        }
        for (int i = 1; i < 60; i++)
        {
            int BadObjectsIndex = Random.Range(0, BadObjects.Count);
            Vector3 spawnPosBad = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(BadObjects[BadObjectsIndex], spawnPosBad, BadObjects[BadObjectsIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
   


    
}
