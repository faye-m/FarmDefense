using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorObjectScript : MonoBehaviour
{
    public GameObject target;
    private float scale;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(target, new Vector3(transform.position.x, 0.05f, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
