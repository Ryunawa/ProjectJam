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

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("j'appelle ça un on trigger enter");
        
        if (col.gameObject.CompareTag("Player"))
        {
            _trigger.Trigger();
        }
    }
}
