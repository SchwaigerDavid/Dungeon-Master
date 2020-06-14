using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class AbfrageL2 : MonoBehaviour
{
    public int count;
    public Animator door;
     bool open = false;
    float timer=60.0f;
    public TextMeshProUGUI time; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        time.text = timer+"s";
        if (Druckplatte.druckcount == count)
        {
            door.GetComponent<Animator>();
            door.SetBool("Open", true);
            open = true;
            Druckplatte.druckcount = 0;
        }
        if (timer <= 0.0f && Druckplatte.druckcount != count) {
            SceneManager.UnloadScene("Level2");
            SceneManager.LoadScene("Level2");
            Debug.Log("Out Of time");
        }

    }
}
