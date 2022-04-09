using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private Animation _anim;
    //public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //animator.enabled = false;
        _anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BreakingIcePlatform()
    {
        Destroy((gameObject));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            Debug.Log("Player step on breakable ice");
            _anim.Play("IcePlatform_Break");
        }
    }
}
