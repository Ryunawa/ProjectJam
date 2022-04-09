using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomUIHelp : MonoBehaviour
{
    private void Start()
    {
        _lifeDisplay.UpdateLifeDisplay(_currentlife);
    }

    #region SkillDisplay

    [SerializeField] private SkillDisplay _skillDisplay;

    public void RandomChangeLol()
    {
        for (int i = 0; i < 5; i++)
        {
            _skillDisplay.Light(i, Random.Range(0,2)==1);
        }
    }

    #endregion
    
    [Space]
    
    #region Dialogs

    [SerializeField] private GameDialog[] _dialogs;
    [SerializeField] private DialogDisplay display;

    public void AddRandomDialogMethod()
    {
        List<GameDialog> dia = new List<GameDialog>();

        for (int i = 1; i < Random.Range(1, 10); i++)
        {
            int index = Random.Range(0, _dialogs.Length);
            Debug.Log(index);
            GameDialog test = _dialogs[index];
            dia.Add(test);
        }
        
        display.AddDialogs(dia.ToArray());
    }

    #endregion

    [Space]

    #region Life

    [SerializeField] private int _currentlife;
    [SerializeField] private LifeDisplay _lifeDisplay;

    public void IncrementLife()
    {
        if(_currentlife + 1 <= 10)
            _lifeDisplay.UpdateLifeDisplay(++_currentlife);
    }

    public void DecrementLife()
    {
        if(_currentlife - 1 >= 0)
            _lifeDisplay.UpdateLifeDisplay(--_currentlife);
    }

    #endregion
}
