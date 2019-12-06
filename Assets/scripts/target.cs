using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    private float scale;
    


    // Start is called before the first frame update
    void Start()
    {
        scale = 1;
        transform.localScale = new Vector3(scale, scale, scale);
        transform.Rotate(-8f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //code to scale the target's size down over time
 
        if (scale > 0.25f)
        {
            scale = scale - 0.00625f;
        }

        // locks scale so that the target and trigger box does not become too small

        else
        {
            scale = 0.25f;
        }
        transform.localScale = new Vector3(scale, scale, scale);
    }

    private void OnTriggerEnter(Collider other)
    {
        //destroys the target when the object is either caught or falls on the roof
        if (other.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
        }
    }
}
