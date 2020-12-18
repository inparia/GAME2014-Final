/**
 * ShrinkingPlatform.cs
 * Joon Young Sun
 * 101216511
 * Last Modified : 2020-12-16
 * Description : Shrinks the platform and plays appropriate sound.
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatform : MonoBehaviour
{
    //Checkers for if platform is going to shrink or not.
    [Header("Shrink Option")]
    public bool willShrink;

    [Header("Audios for Shrinking and Expanding")]
    public AudioSource[] sounds;

    private bool isShrinking, isExpanding;
    
    // Start is called before the first frame update
    void Start()
    {
        isShrinking = false;
    }

    // Update is called once per frame
    void Update()
    {
        // checks if player is on the platform, and it is set to shrink.
        if (willShrink && gameObject.GetComponentInParent<MovingPlatformController>().isActive)
        {
            if(!isShrinking)
            {
                sounds[0].Play();
                isShrinking = true;
            }
            if (gameObject.transform.localScale.x >= 0.0f)
            {
                //If it's scale is greater than 0, decrement its scale.
                gameObject.transform.localScale -= new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }
        }
        else
        {
            if (isShrinking)
            {
                sounds[1].Play();
                isShrinking = false;
            }
            //If it's scale is less than 0, increment its scale.
            if (gameObject.transform.localScale.x <= 1.0f)
            {
                gameObject.transform.localScale += new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
            }

        }

        
    }

}
