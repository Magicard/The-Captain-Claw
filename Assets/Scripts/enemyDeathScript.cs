using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class enemyDeathScript : MonoBehaviour
{
    public GameObject player;
    public GameObject hunnid;
    public GameObject theEnemy;
    private void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player" )
        {
            Instantiate(hunnid, gameObject.transform.position, gameObject.transform.rotation);
            collision.GetComponent<playerInfoScript>().score += 100;
            Destroy(theEnemy, 0f);
        }
        else if (collision.tag == "Bullet")
        {
            Instantiate(hunnid, gameObject.transform.position, gameObject.transform.rotation);
            player.GetComponent<playerInfoScript>().score += 100;
            Destroy(theEnemy, 0f);
        }
    }




}
