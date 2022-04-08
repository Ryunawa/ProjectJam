using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Dialog", fileName = "Dialog")]
public class GameDialog : ScriptableObject
{
    [SerializeField] private string _text;
    
    public string Text => _text;
}
