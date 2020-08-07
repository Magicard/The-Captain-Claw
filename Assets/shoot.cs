using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float bulletDir = 1;
    public GameObject leftGun;
    public GameObject rightGun;
    public GameObject bullet;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<playerInfoScript>().bullets> 0)
        {
            if (Input.GetKeyDown("v"))
            {
                if (rightGun.GetComponent<attackScript>().enemyCheck == true)
                {
                    gameObject.GetComponent<playerInfoScript>().bullets--;
                    bulletDir = 1;
                    Instantiate(bullet, rightGun.transform.GetChild(0).transform.position, rightGun.transform.rotation);
                }
            }
            if (Input.GetKeyDown("z"))
            {
                if (leftGun.GetComponent<attackScript>().enemyCheck == true)
                {
                    gameObject.GetComponent<playerInfoScript>().bullets--;
                    bulletDir = -1;
                    Instantiate(bullet, leftGun.transform.transform.GetChild(0).transform.position, leftGun.transform.rotation);

                }
            }
        }
        
    }

}

