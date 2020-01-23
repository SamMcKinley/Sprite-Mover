using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    private Transform tf;

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
            shiftMove();
        }
        else
        {
            move();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tf.position = new Vector3(0, 0, 0);
        }
    }

    void move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position += new Vector3(0, -speed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
    }

    void shiftMove()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            tf.position += new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tf.position += new Vector3(0,-1,0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tf.position += new Vector3(-1,0,0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tf.position += new Vector3(1,0,0);
        }
    }
}
