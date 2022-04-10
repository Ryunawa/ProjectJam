using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private TextDisplay _textDisplay;
    [SerializeField] private LifeDisplay _lifeDisplay;
    [SerializeField] private SkillDisplay _skillDisplay;

    public void AddDialogs(GameDialog[] dialogs) => _textDisplay.AddDialogs(dialogs);

    public void UpdateLifeDisplay(int currentLife) => _lifeDisplay.UpdateLifeDisplay(currentLife);

    public void Light(int index, bool lightUp = true) => _skillDisplay.Light(index, lightUp);

    public void AddChoice(GameChoice next) => _textDisplay.AddChoice(next);

    public void AddTexts(GameText[] gameTexts) => _textDisplay.AddTexts(gameTexts);
}
