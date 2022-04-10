using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] private Sprite _fullHeart;
    [SerializeField] private Sprite _halfHeart;
    [SerializeField] private Sprite _emptyHeart;
    
    [SerializeField] private Image[] _life;

    private void OnEnable()
    {
        UpdateLifeDisplay(_life.Length * 2);
    }

    public void UpdateLifeDisplay(int currentLife)
    {
        if(currentLife < 0 || currentLife > _life.Length * 2) return;

        int numberOfFull = currentLife / 2;

        bool demi = (currentLife % 2 != 0);

        for (int i = 0; i < numberOfFull; i++)
        {
            _life[i].sprite = _fullHeart;
        }

        if (demi)
        {
            _life[numberOfFull].sprite = _halfHeart;
        }
        
        for (int i = numberOfFull + (demi ? 1 : 0); i < _life.Length; i++)
        {
            _life[i].sprite = _emptyHeart;
        }
    }
}
