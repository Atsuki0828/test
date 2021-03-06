﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            Debug.Log("Go");
        }

        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            Debug.Log("back");
        }
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            Debug.Log("left");
        }
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            Debug.Log("right");
        }
    }
}
