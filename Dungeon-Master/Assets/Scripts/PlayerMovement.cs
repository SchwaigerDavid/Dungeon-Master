using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public Vector2 pos;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        transform.position = pos; 
    }
}
