﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    public Rigidbody2D force;
    float timeleft = 1.0f;
    bool count = false;// start the countdown
    public int verification;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<FixedJoint2D>().enabled == false) {
            Debug.Log("end");
            force.velocity = Vector3.zero;
            timeleft = 1.0f;
            count = false;
        }

    }
    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {
            Debug.Log("true");
            count = true;
        }
        
    }*/
}
