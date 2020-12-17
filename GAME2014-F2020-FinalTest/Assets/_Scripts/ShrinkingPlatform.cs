
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatform : MonoBehaviour
{
    //Checkers for if platform is going to shrink or not.
    public bool willShrink;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // checks if player is on the platform, and it is set to shrink.
        if (willShrink && gameObject.GetComponentInParent<MovingPlatformController>().isActive)
        {
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                //If it's scale is greater than 0, decrement its scale.
                gameObject.transform.localScale -= new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }

        }
        else
        {
            //If it's scale is less than 0, increment its scale.
            if (gameObject.transform.localScale.x <= 1.0f)
            {
                gameObject.transform.localScale += new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }

        }

        
    }

}
