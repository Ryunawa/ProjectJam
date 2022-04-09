using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformBehaviour : MonoBehaviour
{
    private Animation _anim;
    //public Animator animator;
    [SerializeField] private float respawnTime;
    [SerializeField] private UnityEvent<PlatformBehaviour, float> onPlatformDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        //animator.enabled = false;
        _anim = GetComponent<Animation>();
        onPlatformDestroyed = PlatformManager.Instance.onPlatformDestroyed;
    }

    private void BreakingIcePlatform()
    {
        onPlatformDestroyed.Invoke(this, respawnTime);
        //Destroy((gameObject));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.collider.CompareTag("Player")) return;
        //BreakingIcePlatform();
        Debug.Log("Player step on breakable ice");
        _anim.Play("IcePlatform_Break");
    }
}
