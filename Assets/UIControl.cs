using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private DialogDisplay _dialogDisplay;
    [SerializeField] private LifeDisplay _lifePan;
    [SerializeField] private SkillDisplay _skillPan;

    public void ShowDialog()
    {
        _dialogDisplay.gameObject.SetActive(true);
    }
}