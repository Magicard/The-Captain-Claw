using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightingScript : MonoBehaviour
{

    public GameObject leftCol;
    public GameObject rightCol;
    public Rigidbody2D rb2D;
    private float thrust = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (rightCol.GetComponent<attackScript>().enemyCheck == true)
            {
                rb2D.AddForce(Vector2.right * thrust, ForceMode2D.Impulse);
            }
        }
        if (Input.GetKeyDown("q"))
        {
            if (leftCol.GetComponent<attackScript>().enemyCheck == true)
            {
                rb2D.AddForce(Vector2.left * thrust, ForceMode2D.Impulse);
            }
        }

    }
}
