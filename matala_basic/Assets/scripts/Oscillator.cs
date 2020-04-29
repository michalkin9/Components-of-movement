using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{


    [Header("Objects To Animate")]
    public Transform objectTargets;

    [Header("Oscillation - Amplitude & Direction")]
    public Vector3 oscillationVector;

    [Header("Sine Oscillation Attributes")]
    public float angularSpeed;
    public float deltaPhase = 2 * Mathf.PI;

    private Vector3 oldPos;

    void Start()
    {
        oldPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        float phase = angularSpeed * Time.time + deltaPhase / oldPos.x;

        transform.position = oldPos + oscillationVector * Mathf.Sin(phase);



    }
}