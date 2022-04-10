using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextTrigger))]
public class BonusGetter : MonoBehaviour
{
    [SerializeField] private TextTrigger _trigger;
    
    // Start is called before the first frame update
    void Start()
    {
        _trigger = GetComponent<TextTrigger>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _trigger.Trigger();
        }
    }
}
