using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDisplay : MonoBehaviour
{
    [SerializeField] private Color[] _colors;
    [SerializeField] private Image[] _skills;

    private void OnEnable()
    {
        for (int i = 0; i < _skills.Length; i++)
        {
            Light(i, false);
        }
    }

    public void Light(int index, bool lightUp)
    {
        if(index < 0 || index >= _skills.Length) return;

        _skills[index].color = _colors[(lightUp ? 0 : 1)];
    }
}
