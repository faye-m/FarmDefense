using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    private float scale;
    [SerializeField] private Transform planeMid;
    [SerializeField] private Transform planeL1;
    [SerializeField] private Transform planeL2;
    [SerializeField] private Transform planeR1;
    [SerializeField] private Transform planeR2;
    private float timePassed;


    // Start is called before the first frame update
    void Start()
    {
        scale = .50f;
        timePassed = 0;
        //transform.localScale = new Vector3(scale, scale, scale);
        //transform.Rotate(-8f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        timePassed += Time.deltaTime;
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

        if (timePassed > 3)
        {
            Destroy(gameObject);
            timePassed = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //destroys the target when the object is either caught or falls on the roof
        if (other.gameObject.tag == "meteor1" || other.gameObject.tag == "meteor2" || other.gameObject.tag == "meteor3")
        {
            Destroy(gameObject);
        }
    }
}
