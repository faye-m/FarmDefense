using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorInstantiation : MonoBehaviour
{
    public GameObject meteor; 
    private int spawnCount=1;
    private float posY;
    private float posX;
    private float posZ;
    private double spawnTime;
    private float elapsedTime = 0.0f;
    private float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        instantiateRandomized();
    }

    void instantiateRandomized ()
    {
        elapsedTime += Time.deltaTime;
        currentTime++;
        

        if (currentTime % 300 == 0)
        {
            spawnTime = spawnTime - 0.25;
            
        }

        if (spawnTime < 1)
        {
            spawnTime = 1;
        }

        if (elapsedTime > spawnTime)
        {
            elapsedTime = 0;
            for (int n=1; n<=spawnCount; n++)
            {
                posX = Random.Range(-10, 10);
                posZ = Random.Range(-10, 10);
                posY = Random.Range(15, 20);

                Instantiate(meteor, new Vector3(posX, posY, posZ), Quaternion.identity);
            }
            
            
        }
        
    }
}
