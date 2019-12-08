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

        transform.Translate(Input.GetAxis("Mouse Y"), 0, -Input.GetAxis("Mouse X"));

        //transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        clampPosition();
        
    }

    void clampPosition ()
    {

        //clamps the position of the player to set bounds so that the player doesnt go out of bounds

        if (transform.position.z <= -9f || transform.position.z >= 4f)
        {
            print("Code for clamping Z postion here.");
            clampPos.z = Mathf.Clamp(clampPos.z, -9f, 4f);
            transform.position = clampPos;
        }

        if (transform.position.x <= -14f || transform.position.x >= 2f)
        {
            print("Code for clamping X postion here.");
            clampPos.x = Mathf.Clamp(clampPos.x, -14f, 2f);
            transform.position = clampPos;
        }

    }

}
