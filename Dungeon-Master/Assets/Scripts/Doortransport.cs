using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doortransport : MonoBehaviour
{
    public GameObject blackScreen;
    public Animator blackScreenAnim;
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {

            StartCoroutine("newRoom");
        }
    }

    IEnumerator newRoom()
    {
        blackScreen.SetActive(true);
        blackScreenAnim.SetTrigger("leave");

        yield return new WaitForSeconds(1);

        Debug.Log(nextLevel);

        SceneManager.LoadScene(nextLevel);
    }
}
