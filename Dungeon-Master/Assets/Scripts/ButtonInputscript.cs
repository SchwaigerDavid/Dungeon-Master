using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInputscript : MonoBehaviour
{
    public static string code;
    public string awnser;
    public Canvas buttons;
    public GameObject win;
    public GameObject lose;
    public Animator door;

    private bool enter;

    public void b0()
    {
        code += "0";
    }
    public void b1() {
        code += "1";
    }
    public void b2() {
        code += "2";
    }
    public void b3() {
        code += "3"; 
    }
    public void b4() {
        code += "4";
    }
    public void b5() {
        code += "5";
    }
    public void b6() {

        code += "6";
    }
    public void b7() {
        code += "7";
    
    }
    public void b8() {
        code += "8"; 
    
    }

    public void b9() {
        code += "9";
    }
    public void Enter() {

        if (awnser.Equals(code))
        {
            gameObject.SetActive(false);
            door.GetComponent<Animator>();
            door.SetBool("Open",true);
            lose.SetActive(false);
        }
        else {
            door.GetComponent<Animator>();
            door.SetBool("Open", false);
            gameObject.SetActive(true);
            lose.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
        if (collision.gameObject.tag == "Player")
        {
            enter = true;
        }
        else
        {
            enter = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.tag == "Player")
        {
            enter = false;
            buttons.enabled = false;
        }
    }



    void Update()
    {
        if (enter == true && Input.GetKey(KeyCode.E))
        {
            buttons.enabled = true;

        }

    }



}
