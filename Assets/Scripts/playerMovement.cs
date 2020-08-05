using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public GameObject ladderObj;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    public bool onLadder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onLadder = ladderObj.GetComponent<ladderScript>().onLadder;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (!onLadder)
        {
            if (Input.GetButtonDown("Jump"))
            {
            jump= true;
            }

        }
        if (Input.GetKeyDown("r"))
        {
            crouch = true;
        }

        else if (Input.GetKeyUp("r"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove* Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
   

}
