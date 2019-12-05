using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private float movementMultiplier = 10;
    private Vector3 clampPos;

    // Start is called before the first frame update
    void Start()
    {
        clampPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        clampPos.z = Mathf.Clamp(clampPos.z, -8.5f, 8.5f);
        //transform.Translate(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
        transform.position = clampPos;
    }
}
