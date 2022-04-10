using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameText : ScriptableObject
{
    [SerializeField] protected string author;
    [SerializeField] protected string _text;
    
    [SerializeField] protected Sprite _leftImage;
    [SerializeField] protected Sprite _rightImage;
    
    public string Text => author + " : " + _text;
    
    public Sprite LeftImage => _leftImage;
    
    public Sprite RightImage => _rightImage;
}
