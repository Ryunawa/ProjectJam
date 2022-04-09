using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    private bool _triggeredOnce;
    [SerializeField] private GameDialog[] _dialog;

    public void Trigger()
    {
        if(_triggeredOnce) return;
        
        GameManager.Instance.AddDialogs(_dialog);
        _triggeredOnce = true;
    }
}
