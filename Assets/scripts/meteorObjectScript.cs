using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorObjectScript : MonoBehaviour
{
    public GameObject target;
    private float scale;
    private float posY = 20.8f;
    [SerializeField] private Transform planeMid;
    [SerializeField] private Transform planeL1;
    [SerializeField] private Transform planeL2;
    [SerializeField] private Transform planeR1;
    [SerializeField] private Transform planeR2;


    // Start is called before the first frame update
    void Start()
    {

        // spawns a target guide to help player know where to position the basket to catch the meteors
        //Instantiate(target, new Vector3(transform.position.x, planeMid.transform.position.y, transform.position.z), Quaternion.identity);
        //print(planeMid.transform.localRotation);

        if (transform.position.x <= -6 && transform.position.x >= -11)
        {
            Instantiate(target, new Vector3(transform.position.x, planeMid.transform.position.y, transform.position.z), planeMid.transform.rotation);
            
        }

        else if (transform.position.x < -11 && transform.position.x >= -19)
        {
            Instantiate(target, new Vector3(transform.position.x, planeL1.transform.position.y, transform.position.z), planeL1.transform.rotation);
        }

        else if (transform.position.x > -6 && transform.position.x <= 5)
        {
            Instantiate(target, new Vector3(transform.position.x, planeR1.transform.position.y, transform.position.z), planeR1.transform.rotation);
        }

        else if (transform.position.x > 5)
        {
            Instantiate(target, new Vector3(transform.position.x, planeR2.transform.position.y, transform.position.z), planeR2.transform.rotation);
        }

        else if (transform.position.x < -19)
        {
            Instantiate(target, new Vector3(transform.position.x, planeL2.transform.position.y, transform.position.z), planeL2.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
