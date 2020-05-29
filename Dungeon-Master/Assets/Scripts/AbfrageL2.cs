using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbfrageL2 : MonoBehaviour
{
    public int count;
    public Animator door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Druckplatte.druckcount == count)
        {
            door.GetComponent<Animator>();
            door.SetBool("Open", true);
            Druckplatte.druckcount = 0;
        }
    }
}
