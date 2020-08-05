using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackScript : MonoBehaviour
{
    public Material red;
    public Material green;
    public bool enemyCheck= false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (enemyCheck== false)
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
        if (collision.CompareTag("Tag"))
        {
            enemyCheck = true;
        }
    }

}
