using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // adds total points whenever a meteor is caught in the basket, also destroys the meteor to make it disappear
        if (other.gameObject.tag=="meteor")
        {
            Destroy(other.gameObject);
            score++;
            print(score);
        }
    }
}
