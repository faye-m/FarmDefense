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
    private float countTime = 0.0f;

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
                posX = Random.Range(-5, 5);
                posZ = Random.Range(-5, 5);
                posY = Random.Range(35, 40);

                Instantiate(meteor, new Vector3(posX, posY, posZ), Quaternion.identity);
            }
            
        } 
        
    }
}
