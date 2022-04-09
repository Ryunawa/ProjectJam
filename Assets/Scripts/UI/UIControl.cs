using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private DialogDisplay _dialogDisplay;
    [SerializeField] private LifeDisplay _lifeDisplay;
    [SerializeField] private SkillDisplay _skillDisplay;

    public void AddDialog(GameDialog[] dialog)
    {
        _dialogDisplay.AddDialogs(dialog);
    }
}
