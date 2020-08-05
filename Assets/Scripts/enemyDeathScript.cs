using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeathScript : MonoBehaviour
{
    public GameObject theEnemy;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.tag== "Player")
        {
            Destroy(theEnemy, 0f);
        }
    }




}
