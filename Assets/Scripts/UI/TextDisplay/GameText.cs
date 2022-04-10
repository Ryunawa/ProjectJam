using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameText : ScriptableObject
{
    [SerializeField] protected string author;
    [SerializeField][TextArea] protected string _text;
    
    [SerializeField] protected Sprite _leftImage;
    [SerializeField] protected Sprite _rightImage;

    [SerializeField] protected bool _goodEnd;
    [SerializeField] protected BonusPath.BonusPathValue _path;

    public string Text => author + " : " + _text;
    
    public Sprite LeftImage => _leftImage;
    
    public Sprite RightImage => _rightImage;
}
