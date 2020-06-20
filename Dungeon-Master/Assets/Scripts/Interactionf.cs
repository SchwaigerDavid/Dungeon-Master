using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactionf : MonoBehaviour
{
    public TextMeshProUGUI texts;
    public Canvas textons;
    public TextMeshProUGUI Titles;


    public string titles;
    public string inhalts = "placeholder";

    private bool enters = false;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.gameObject.tag == "Player")
        {
            enters = true;
        }
        else
        {
            enters = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.tag == "Player")
        {
            enters = false;
            textons.enabled = false;
        }
    }



    void Update()
    {
        if (enters == true && Input.GetKey(KeyCode.E))
        {
            textons.enabled = true;
            Titles.text = titles;
            texts.text = inhalts;
        }
        if (ButtonInputscript.type == true && gameObject.tag.Equals("Rätsel"))
        {
            texts.text = null;
            texts.text += ButtonInputscript.code;
            ButtonInputscript.type = false;
        }
    }
}
