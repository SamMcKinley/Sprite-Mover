﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public Transform tf;

    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move up if the player presses up
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //Only Works if shift is held down
        }

        {
            //Only Works if shift is not held down
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position = tf.position + Vector3.up * Time.deltaTime * speed;

        }

    }
}
