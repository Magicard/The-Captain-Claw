using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightFollowScript : MonoBehaviour
{
    public GameObject player;
    public float distance= 1.88f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(player.transform.position.x + distance, player.transform.position.y);
    }
}
