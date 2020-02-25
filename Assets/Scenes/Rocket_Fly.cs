﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Fly : MonoBehaviour
{

    Rigidbody rigidBody;
    AudioSource rocketThrust;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rocketThrust = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!rocketThrust.isPlaying)
            {
                rocketThrust.Play();
            }
        }
        else
        {
            rocketThrust.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward / 5);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward / 5);
        }
    }
}