using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogDisplay : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private List<GameDialog> _dialogs;

    private void OnEnable()
    {
        Next();
    }

    public void AddDialog(GameDialog dialog)
    {
        _dialogs.Add(dialog);
    }

    public void Next()
    {
        if (_dialogs.Count > 0)
        {
            _text.text = _dialogs[0].Text;
            _dialogs.RemoveAt(0);
            return;
        }
        
        _text.text = "";
    }
}
