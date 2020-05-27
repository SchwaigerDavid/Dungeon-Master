﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Vector2 pos;
    public Rigidbody2D body;

    private float x, y;
    public SpriteRenderer flip;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if (x > 0 || x == 0) {
            flip.flipX = false;
        }
        else if (x<0) {
            flip.flipX = true;
        }
        var moveVector = new Vector3(x, y, 0);

        body.MovePosition(new Vector2((transform.position.x + moveVector.x * speed * Time.deltaTime),
            transform.position.y + moveVector.y * speed * Time.deltaTime));
    }
}
