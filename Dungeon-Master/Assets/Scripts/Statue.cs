using System.Collections;
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
<<<<<<< HEAD
<<<<<<< HEAD
            Debug.Log("end");
=======
>>>>>>> 583bcb5a1999d7010b19c52251be43456fd0fcc8
=======
>>>>>>> b17d594714d759a18afabfc84ccda106b65567eb
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
