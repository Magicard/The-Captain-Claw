using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttackScript : MonoBehaviour
{
    public Material red;
    public Material green;
    public bool enemyCheck = false;

    void FixedUpdate()
    {
        if (enemyCheck == false)
        {
            gameObject.GetComponent<MeshRenderer>().material = green;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = red;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enemyCheck = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enemyCheck = true;
        }
    }
}
