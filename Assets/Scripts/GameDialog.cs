using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Dialog", fileName = "Dialog")]
public class GameDialog : ScriptableObject
{
    [SerializeField] private string author;
    [SerializeField] private string _text;
    [SerializeField] private Sprite _leftImage;
    [SerializeField] private Sprite _rightImage;


    private string Author => (author.Length > 0 ? author : "System") + " : ";
    
    public string Text => Author + _text;
    
    public Sprite LeftImage => _leftImage;
    
    public Sprite RightImage => _rightImage;
}
