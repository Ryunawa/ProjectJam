using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    private bool _wasAlreadyTriggered = false; 
    [SerializeField] private bool _triggerOnce;
    [SerializeField] private GameText[] _gameTexts;

    public void Trigger()
    {
        if(_triggerOnce && _wasAlreadyTriggered) return;

        GameManager.Instance.AddGameTexts(_gameTexts);
        
        if (_triggerOnce)
            _wasAlreadyTriggered = true;
    }
}
