using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class AddRandomDialog : MonoBehaviour
{
    [SerializeField] private GameDialog[] _dialogs;
    [SerializeField] private DialogDisplay display;

    public void AddRandomDialogMethod()
    {
        List<GameDialog> dia = new List<GameDialog>();

        for (int i = 0; i < Random.Range(1, 10); i++)
        {
            dia.Add(_dialogs[Random.Range(0, _dialogs.Length)]);
        }
        
        display.AddDialogs(dia.ToArray());
    }
}
