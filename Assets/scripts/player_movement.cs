﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    private float movementMultiplier = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*movementMultiplier, 0, Input.GetAxis("Vertical") * Time.deltaTime*movementMultiplier);
    }
}
