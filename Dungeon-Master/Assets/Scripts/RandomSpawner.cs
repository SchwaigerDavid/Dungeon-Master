using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour      //Script in BETA, noch nicht funktionsfähig!!!!!
{                                               //Tutorial: https://youtu.be/WGn1zvLSndk
    public GameObject[] objekte;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    int randEnemy;

    void Start()
    {
        
    }


    void Update()
    {
        StartCoroutine( waitSpawner());
    }

    IEnumerator waitSpawner()
    {
    while (true)
    {
        randObject= Random.Range (0, objekte.length);

        Vector3 spawnPosition= new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range (-spawnValues.y, spawnValues.y));

        Instantiate (objekte[randObject], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

    }
}
}
