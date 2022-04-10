using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    [SerializeField] private bool _triggerOnce;
    [SerializeField] private bool _wasAlreadyTriggered; 
    [SerializeField] private GameText[] _gameTexts;

    public void Trigger()
    {
        if(_triggerOnce && _wasAlreadyTriggered) return;

        GameManager.Instance.AddGameTexts(_gameTexts);
        
        if (_triggerOnce)
            _wasAlreadyTriggered = true;
    }
}
