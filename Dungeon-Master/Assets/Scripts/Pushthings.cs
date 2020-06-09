using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushthings : MonoBehaviour
{
    public float distance=1f;
    public float downdist = 1f;
    public LayerMask boxMask;
    GameObject box;
    bool hitten=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false; 
        RaycastHit2D hit =Physics2D.Raycast(transform.position,Vector2.right*transform.localScale.x,distance,boxMask);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x, distance, boxMask);
        RaycastHit2D hit3 = Physics2D.Raycast(transform.position, Vector2.up * transform.localScale.y, downdist, boxMask);
        RaycastHit2D hit4 = Physics2D.Raycast(transform.position, Vector2.down * transform.localScale.y, downdist, boxMask);
        if (hit.collider!= null && Input.GetKeyDown(KeyCode.F)) {
            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            hitten = true;
            Debug.Log("Hi");
        
        }
        else if (hit2.collider != null && Input.GetKeyDown(KeyCode.F))
        {
            box = hit2.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            hitten = true;
            Debug.Log("Hi");

        }
        else if (hit3.collider != null && Input.GetKeyDown(KeyCode.F))
        {
            box = hit3.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            hitten = true;
            Debug.Log("Hi");

        }
        else if (hit4.collider != null && Input.GetKeyDown(KeyCode.F))
        {
            box = hit4.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            hitten = true;
            Debug.Log("Hi");

        }

        if (hitten==true&&Input.GetKeyUp(KeyCode.F)) {
            box.GetComponent<FixedJoint2D>().enabled = false;
            hitten = false;
            Debug.Log("OUT");
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,(Vector2) transform.position + Vector2.right * transform.localScale.x * distance);
        Gizmos.DrawLine(transform.position,(Vector2) transform.position + Vector2.left * transform.localScale.x * distance);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.up * transform.localScale.y * downdist);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.down * transform.localScale.y * downdist);
    }
}
