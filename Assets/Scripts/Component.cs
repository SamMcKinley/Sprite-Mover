using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    public SpriteMover SpriteMover;
    // Start is called before the first frame update
    void Start()
    {
        SpriteMover = gameObject.GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))

        {
            SpriteMover.enabled = (!SpriteMover.enabled);
        }

    }
}
