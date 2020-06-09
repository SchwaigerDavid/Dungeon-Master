using System.Collections;
using UnityEngine;

public class RandomSpawner : MonoBehaviour      
{                                               //Tutorial: https://youtu.be/WGn1zvLSndk
    public GameObject[] elemente;
    public Vector2 spawnKoordinaten;
    int zufallsElement;

    void Start()
    {
        waitSpawner();
    }


    void Update()
    {
        
    }

    void waitSpawner()
    {
    

        for(int i=0; i< elemente.Length; i++)
        {
        zufallsElement= Random.Range (0, elemente.Length);

        Vector3 spawnPosition= new Vector2 (Random.Range (-spawnKoordinaten.x, spawnKoordinaten.x),  Random.Range (-spawnKoordinaten.y, spawnKoordinaten.y));

        Instantiate (elemente[zufallsElement], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

           
        }
    }
}
