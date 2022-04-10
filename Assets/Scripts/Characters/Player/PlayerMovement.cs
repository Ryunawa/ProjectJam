using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float runSpeed = 5f;


    float horizontalMove = 0.0f;
    bool jump = false;
    bool crouch = false;
    bool leftAttack;
    
    
    void start()
    {
        
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            leftAttack = true;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            leftAttack = false;
        }
    }

    void FixedUpdate()
    {
        // To move our character
        controller.Move(horizontalMove, crouch, jump, leftAttack);
        jump = false;
    }
}
