using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 50.0f;
    public float turnSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     float left = Input.GetAxis("Left");
     float right = Input.GetAxis("Right");
     float turn = (left - right) *speed*Time.deltaTime;
     float movement = (left +right) *turnSpeed*Time.deltaTime;

     Transform t = gameObject.transform;
     t.Translate (0.0f,0.0f,movement);
     t.Rotate(0.0f,turn,0.0f);

    }
}
