using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Druckplatte : MonoBehaviour
{
    public static int druckcount=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Statue")) {
            druckcount++;
        }
    }
}
