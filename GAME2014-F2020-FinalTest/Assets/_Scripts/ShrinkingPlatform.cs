
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatform : MonoBehaviour
{

    public bool willShrink;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // && gameObject.GetComponentInParent<MovingPlatformController>().isActive
        if (willShrink && gameObject.GetComponentInParent<MovingPlatformController>().isActive)
        {
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                gameObject.transform.localScale -= new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }

        }
        else
        {
            if (gameObject.transform.localScale.x <= 1.0f)
            {
                gameObject.transform.localScale += new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }

        }

        
    }

}
