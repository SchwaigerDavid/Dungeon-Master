using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    public GameObject text;

    public string code;

    private bool enter = false;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButton("Fire1"))
        {
            Debug.Log("pressed");

            if (gameObject.tag == "Rätsel")
            {
                text.SetActive(true);
            }
            else if(gameObject.tag == "Enter")
            {
                Debug.Log("ent");
                enter = true;
            }
        }
    }

    void Update()
    {
    }
}
