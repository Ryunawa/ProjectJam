using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRandom : MonoBehaviour
{
    [SerializeField] private SkillDisplay _skillDisplay;

    public void RandomChangeLol()
    {
        for (int i = 0; i < 5; i++)
        {
            _skillDisplay.Light(i, Random.Range(0,2)==1);
        }
    }
}
