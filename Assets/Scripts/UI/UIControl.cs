using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private DialogDisplay _dialogDisplay;
    [SerializeField] private LifeDisplay _lifeDisplay;
    [SerializeField] private SkillDisplay _skillDisplay;

    public void AddDialogs(GameDialog[] dialogs) => _dialogDisplay.AddDialogs(dialogs);

    public void UpdateLifeDisplay(int currentLife) => _lifeDisplay.UpdateLifeDisplay(currentLife);

    public void Light(int index, bool lightUp = true) => _skillDisplay.Light(index, lightUp);
}
