using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropsOnHouse : MonoBehaviour
{
    private int houseHP;
    // Start is called before the first frame update
    void Start()
    {
        houseHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        gameOverCheck();
    }

    //code checks for collisions on the object and destroys the object that collides with it
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="meteor")
        {
            Destroy(other.gameObject);
            //houseHP--;
        }
    }

    void gameOverCheck()
    {
        if (houseHP == 0)
        {
            //print("GAME OVER!");
        }

        else if (houseHP < 0)
        {
            //houseHP = 0;
        }
    }
}
