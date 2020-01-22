using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare variables at top
    private SpriteRenderer SpriteRenderer;
    public Color color = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (SpriteRenderer != null)
        {
        SpriteRenderer.color = Color.green;
       
        }
        else
        {
          Debug.LogError("No Sprite Renderer Attached");  
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SpriteRenderer != null)
        {
            SpriteRenderer.color = color;
        }
        else
        {
            Debug.LogError("No Sprite Renderer Attached");
        }
    }
}
