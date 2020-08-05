using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderScript : MonoBehaviour
{
    public GameObject player;
    public bool onLadder = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Vertical"))
        {
            player.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 10f * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            onLadder = true;
            player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onLadder = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 3f;
    }
}
