using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class BoulderBehaviour : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;
    
    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = _sprite;
    }
}
