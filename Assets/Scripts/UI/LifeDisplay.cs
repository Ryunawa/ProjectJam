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

    public void UpdateLifeDisplay(int currentLife)
    {
        int maxLife = _life.Length * 2;
        
        if (currentLife >= maxLife || currentLife <= 0)
            currentLife = maxLife / 2; 
        
        int firstEmptyHeartIndex = currentLife / 2;

        for (int i = 0; i < firstEmptyHeartIndex; i++)
        {
            _life[i].sprite = _fullHeart;
        }

        if (currentLife % 2 == 1)
        {
            _life[firstEmptyHeartIndex].sprite = _halfHeart;

            firstEmptyHeartIndex++;
        }

        for (int i = firstEmptyHeartIndex; i < _life.Length; i++)
        {
            _life[i].sprite = _emptyHeart;
        }
    }
}
