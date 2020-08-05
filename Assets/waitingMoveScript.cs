using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitingMoveScript : MonoBehaviour
{
    public GameObject player;
    public GameObject currentEnemy;
    public bool foundTarget = false;
    public float force= 10f;

    public bool isCoroutineStarted = false;
    public Rigidbody2D rb2D;

    public GameObject rightCol;
    public GameObject leftCol;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rightCol.GetComponent<enemyAttackScript>().enemyCheck == true)
        {
            rb2D.velocity = Vector3.zero;
            rb2D.AddForce(Vector2.right * (force+ 10f), ForceMode2D.Impulse);
        }
        else if (leftCol.GetComponent<enemyAttackScript>().enemyCheck == true)
        {
            rb2D.velocity = Vector3.zero;
            rb2D.AddForce(Vector2.left * (force+ 10f), ForceMode2D.Impulse);
        }
        else
        {
            if (!isCoroutineStarted)
            {
                rb2D.velocity = Vector3.zero;
                StartCoroutine(upAndDown());
            }
        }
    }

    /*void OnTriggerStay2D(Collider2D collision)
    {
        if (rightCol.GetComponent<attackScript>().enemyCheck == true )
        {
            foundTarget = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        foundTarget = false;
    }
    */
    IEnumerator upAndDown()
    {
        isCoroutineStarted = true;
        /*currentEnemy.transform.position = new Vector3(Mathf.Lerp(currentEnemy.transform.position.x, currentEnemy.transform.position.x+ 7f,1), gameObject.transform.position.y);
        yield return new WaitForSeconds(2);
        currentEnemy.transform.position = new Vector3(Mathf.Lerp(currentEnemy.transform.position.x, currentEnemy.transform.position.x - 14f,1), gameObject.transform.position.y);
        yield return new WaitForSeconds(2);
        currentEnemy.transform.position = new Vector3(Mathf.Lerp(currentEnemy.transform.position.x, currentEnemy.transform.position.x + 14f, 1), gameObject.transform.position.y);
        yield return new WaitForSeconds(2);
        StartCoroutine(upAndDown());*/

        
        

        
        rb2D.AddForce(Vector2.left * (force), ForceMode2D.Impulse);
        Debug.Log("left");
        yield return new WaitForSeconds(2);
        rb2D.velocity = Vector3.zero;

        rb2D.AddForce(Vector2.right * (force), ForceMode2D.Impulse);
        Debug.Log("right");
        yield return new WaitForSeconds(2);
        rb2D.velocity = Vector3.zero;
        StartCoroutine(upAndDown());


    }
}
