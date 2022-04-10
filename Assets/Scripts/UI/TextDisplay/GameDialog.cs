using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptableobjects/Dialog", fileName = "Dialog")]
public class GameDialog : GameText
{
    [SerializeField] protected GameText _next;

    public void Activate()
    {
        if (_next)
            BonusPathManager.Instance.Answered(_next);
        else
            BonusPathManager.Instance.Answered(_path, _goodEnd);
    }
}
