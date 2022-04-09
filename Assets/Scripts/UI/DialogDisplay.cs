using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;

public class DialogDisplay : MonoBehaviour
{
    [SerializeField] private Image[] _images;
    [SerializeField] private Text _text;
    [SerializeField] private List<GameDialog> _dialogs;
    [SerializeField] private GameObject _button;

    private void OnEnable()
    {
        Next();
    }

    public void AddDialogs(GameDialog[] dialogs)
    {
        foreach (GameDialog dialog in dialogs)
            AddDialog(dialog);
        
        TogglePanel(true);
    }

    private void AddDialog(GameDialog dialog)
    {
        _dialogs.Add(dialog);
    }

    public void Next()
    {
        if (_dialogs.Count != 0)
        {
            _text.text = _dialogs[0].Text;
            if (_dialogs[0].LeftImage != null)
            {
                _images[0].enabled = true;
                _images[0].sprite = _dialogs[0].LeftImage;
            }
            else
                _images[0].enabled = false;
            
            if (_dialogs[0].RightImage != null)
            {
                _images[1].enabled = true;
                _images[1].sprite = _dialogs[0].RightImage;
            }
            else
                _images[1].enabled = false;
            
            _dialogs.RemoveAt(0);
        }
        else
        {
            TogglePanel(false);
        }
    }

    private void TogglePanel(bool active)
    {
        _images[0].enabled = active;
        _images[1].enabled = active;
        _button.SetActive(active);
        
        if(active) Next();
    }
}
