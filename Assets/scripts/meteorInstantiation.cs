using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorInstantiation : MonoBehaviour
{
    public GameObject meteor1;
    public GameObject meteor2;
    public GameObject meteor3;
    private int spawnCount=1;
    private float posY;
    private float posX;
    private float posZ;
    private double spawnTime;
    private float elapsedTime = 0.0f;
    private float countTime = 0.0f;
    private int randNum;

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

    // custom method that randomizes the spawn location of the object
    void instantiateRandomized ()
    {
        elapsedTime += Time.deltaTime;
        countTime++;

        //spawnTime = 1; //testing
        //this bit of code lessens the time between object spawning when the countTime has no remainder when divided by the number
        if (countTime % 300 == 0)
        {
            spawnTime = spawnTime - 0.25;
            
        }

        //When the spawn time gets too low, this code sets a cap on the value
        if (spawnTime < 1)
        {
            spawnTime = 1;
        }

        //this code generates the object based on the spawn time and randomized coordinates
        if (elapsedTime > spawnTime)
        {
            elapsedTime = 0;
            for (int n=1; n<=spawnCount; n++)
            {
                randNum = Random.Range(1, 4);
                posX = Random.Range(-12, 1);
                posZ = Random.Range(-3, 3);
                posY = Random.Range(40, 45);

                if (randNum == 1)
                {
                    Instantiate(meteor1, new Vector3(posX, posY, posZ), Quaternion.identity);
                }

                else if (randNum == 2)
                {
                    Instantiate(meteor2, new Vector3(posX, posY, posZ), Quaternion.identity);
                }

                else
                {
                    Instantiate(meteor3, new Vector3(posX, posY, posZ), Quaternion.identity);
                }

                
            }
            
        } 
        
    }
}
