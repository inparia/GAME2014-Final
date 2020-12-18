/**
 * FloatingEffect.cs
 * Joon Young Sun
 * 101216511
 * Last Modified : 2020-12-16
 * Description : Adds floating effect to the platform.
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingEffect : MonoBehaviour
{
    // Start is called before the first frame update

    // Saves the original position.

    [Header("Original Platform Position")]
    float originalY;

    //Sets its floating strength. It can also be set in editor.
    [Header("Strength of floating")]
    public float floatStrength = 0.3f;
    void Start()
    {
        //Sets the original position to current position.
        this.originalY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Once it float up, then it float down.
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time) * floatStrength),
            transform.position.z);
    }
}
