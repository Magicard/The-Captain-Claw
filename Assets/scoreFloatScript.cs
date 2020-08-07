using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreFloatScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(gameObject, 2f);
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, Mathf.Lerp(gameObject.transform.position.y, gameObject.transform.position.y + 50, 0.05f * Time.deltaTime));

    }
}
