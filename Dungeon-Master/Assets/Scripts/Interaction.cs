using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interaction : MonoBehaviour
{

    public TextMeshProUGUI text;
    public Canvas texton;
    public TextMeshProUGUI Title; 


    public string title;
    public string code;

    private bool enter = false;

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            Debug.Log("pressed");

            if (gameObject.tag == "Rätsel")
            {
                texton.SetActive(true);
                text.text = code;

            }
            else if (gameObject.tag == "Enter")
            {
                Debug.Log("ent");
                enter = true;
            }
        }
    }*/
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 583bcb5a1999d7010b19c52251be43456fd0fcc8
=======

>>>>>>> b17d594714d759a18afabfc84ccda106b65567eb
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
        else {
            enter = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.tag=="Player") {
            enter = false;
            texton.enabled=false;
        }
    }



    void Update()
    {
        if (enter == true && Input.GetKey(KeyCode.E)) {
            texton.enabled=true;
            Title.text = title; 
            text.text = code;
        }
    }
}
