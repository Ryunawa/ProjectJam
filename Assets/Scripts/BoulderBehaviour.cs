using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BoulderBehaviour : MonoBehaviour
{
    [SerializeField] private TextTrigger _trigger;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _boulderDestroyer;

    private void Start()
    {
        _trigger = GetComponent<TextTrigger>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<DamageDealer>().DealDamage(collision.gameObject.GetComponent<PlayerLife>());
            GameManager.Instance.Respawn();
            _trigger.Trigger();
        }
        else if(collision.gameObject == _boulderDestroyer)
            ResetPos();
    }

    private void ResetPos()
    {
        transform.position = _spawnPoint.position;
    }
}
