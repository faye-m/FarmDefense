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
        movementMultiplier = Time.deltaTime * 10;
        transform.Translate(Input.GetAxis("Mouse Y") * movementMultiplier, 0, -Input.GetAxis("Mouse X") * movementMultiplier);

        //transform.Translate(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        clampPosition();
        
    }

    void clampPosition ()
    {

        //clamps the position of the player to set bounds so that the player doesnt go out of bounds

        if (transform.position.z <= -11f || transform.position.z >= 9f)
        {
            print("Code for clamping Z postion here.");
            clampPos.z = Mathf.Clamp(clampPos.z, -11f, 9f);
            transform.position = clampPos;
        }

        if (transform.position.x <= -17f || transform.position.x >= 6f)
        {
            print("Code for clamping X postion here.");
            clampPos.x = Mathf.Clamp(clampPos.x, -17f, 6f);
            transform.position = clampPos;
        }

    }

}
