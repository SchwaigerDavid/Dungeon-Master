using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doortransport : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {
            SceneManager.LoadScene("Level2");
            SceneManager.UnloadScene("Level");
        }
    }
}
