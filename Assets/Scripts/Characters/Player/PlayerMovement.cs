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
    bool physicalAttack = false;
    bool magicAttack = false;
    
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
            physicalAttack = true;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            physicalAttack = false;
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            magicAttack = true;
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            magicAttack = false;
        }
    }

    void FixedUpdate()
    {
        // To move our character
        controller.Move(horizontalMove, crouch, jump, physicalAttack, magicAttack);
        jump = false;
    }
}
