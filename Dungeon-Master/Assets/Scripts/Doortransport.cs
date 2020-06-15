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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        Debug.Log(nextLevel);

>>>>>>> 583bcb5a1999d7010b19c52251be43456fd0fcc8
=======
        Debug.Log(nextLevel);

>>>>>>> b17d594714d759a18afabfc84ccda106b65567eb
=======
        Debug.Log(nextLevel);

>>>>>>> b17d594714d759a18afabfc84ccda106b65567eb
        SceneManager.LoadScene(nextLevel);
    }
}
