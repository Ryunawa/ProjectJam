using System;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    [SerializeField] private List<GameText> _texts;

    [SerializeField] private DialogSetup _dialogSetup;
    [SerializeField] private ChoiceSetup _choiceSetup;

    private void OnEnable()
    {
        Next();
    }

    public void AddDialogs(GameDialog[] dialogs)
    {
        foreach (GameDialog dialog in dialogs)
            AddDialog(dialog);
        
        Next();
    }

    private void AddDialog(GameDialog dialog)
    {
        _texts.Add(dialog);
    }
    
    public void AddChoice(GameChoice next)
    {
        _texts.Add(next);
        Next();
    }

    public void Next()
    {
        if (_texts.Count == 0)
        {
            TogglePanel(false);
            return;
        }
        
        GameText gt = _texts[0];

        switch (gt)
        {
            case GameDialog { } dialog:
                _dialogSetup.Setup(dialog);
                break;
            case GameChoice { } choice:
                _choiceSetup.Setup(choice);
                break;
        }

        _texts.RemoveAt(0);
    }


    private void TogglePanel(bool active)
    {
        if (!active)
        {
            _choiceSetup.Hide();
            _dialogSetup.Hide();
        }
        else
            Next();
    }

    public void AddTexts(GameText[] gameTexts)
    {
        foreach (GameText gameText in gameTexts)
            _texts.Add(gameText);
        
        Next();
    }
}
