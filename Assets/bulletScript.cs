using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    float face;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        rb = gameObject.GetComponent<Rigidbody2D>();

        face = player.GetComponent<shoot>().bulletDir;
       /* player = GameObject.FindGameObjectsWithTag("Player")[0];
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (player.GetComponent<playerMovement>().facing == 1)
        {
            rb.AddForce(Vector3.right * 1000f * Time.deltaTime, ForceMode2D.Impulse);
        }
        else if (player.GetComponent<playerMovement>().facing == -1)
        {
            rb.AddForce(Vector3.left * 1000f * Time.deltaTime, ForceMode2D.Impulse);
        }*/
    }

    private void FixedUpdate()
    {
        if (face== 1)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 100f * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 100f * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tag")
        {
            Destroy(gameObject, 0f);
        }
        
    }

    // Update is called once per frame
}
