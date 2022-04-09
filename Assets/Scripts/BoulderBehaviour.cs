using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BoulderBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _boulderDestroyer;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
//        Debug.Log(collision.gameObject.name);

        if (collision.gameObject == _boulderDestroyer)
        {
            ResetPos();
        }
    }

    private void ResetPos()
    {
        transform.position = _spawnPoint.position;
    }
}
