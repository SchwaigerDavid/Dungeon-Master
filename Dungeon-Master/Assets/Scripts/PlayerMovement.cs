using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=3f;
   // public Vector2 pos;
    //public Rigidbody2D body;
    public SpriteRenderer flip;
    Vector2 moveVector;


    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y= Input.GetAxisRaw("Vertical");
       
        if (moveVector.x > 0 || moveVector.x == 0) {
            flip.flipX = false;
        }
        else if (moveVector.x<0) {
            flip.flipX = true;
        }
       // body.MovePosition(new Vector2((transform.position.x + moveVector.x * speed * Time.deltaTime),
         //   transform.position.y + moveVector.y * speed * Time.deltaTime));
    }
    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().MovePosition(gameObject.GetComponent<Rigidbody2D>().position+moveVector*speed*Time.deltaTime);
    }
}
