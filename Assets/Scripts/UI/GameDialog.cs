using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Talk/Dialog", fileName = "Dialog")]
public class GameDialog : ScriptableObject
{
    [SerializeField] protected string author;
    [SerializeField] protected string _text;
    [SerializeField] protected Sprite _leftImage;
    [SerializeField] protected Sprite _rightImage;
    
    public string Text => author + " : " + _text;
    public Sprite LeftImage => _leftImage;
    public Sprite RightImage => _rightImage;
}
