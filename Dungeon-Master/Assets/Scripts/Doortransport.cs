using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doortransport : MonoBehaviour
{
    public string nextLevel;
    public string thisLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {
            SceneManager.LoadScene(nextLevel);
            SceneManager.UnloadScene(thisLevel);
        }
    }
}
