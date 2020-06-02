using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBegin : MonoBehaviour
{

    public GameObject blackScreen;
    public Animator blackScreenAnimator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("begin");
    }

    IEnumerator begin()
    {
        blackScreenAnimator.SetTrigger("enter");

        yield return new WaitForSeconds(1);

        blackScreen.SetActive(false);
    }
}
