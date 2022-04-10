using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;

    private void OnTriggerEnter2D(Collider2D col)
    {
        col.transform.position = _endPoint.position;
    }
}
