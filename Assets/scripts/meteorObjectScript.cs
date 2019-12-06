using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorObjectScript : MonoBehaviour
{
    public GameObject target;
    private float scale;
    private float posY = 20.8f;

    // Start is called before the first frame update
    void Start()
    {

        // spawns a target guide to help player know where to position the basket to catch the meteors
        Instantiate(target, new Vector3(transform.position.x, posY, transform.position.z), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
