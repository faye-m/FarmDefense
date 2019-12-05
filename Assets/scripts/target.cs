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
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if (scale > 0.5f)
        {
            scale = scale - 0.00625f;
        }

        else
        {
            scale = 0.5f;
        }
        transform.localScale = new Vector3(scale, scale, scale);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
        }
    }
}
