using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteDisabler : MonoBehaviour
{
    public SpriteMover SpriteMover;
    // Start is called before the first frame update
    void Start()
    {
        
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
