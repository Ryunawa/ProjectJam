using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptableobjects/Talk/Choice", fileName = "Choice")]
public class GameChoice : GameDialog
{
    [SerializeField] private string _firstChoice;
    [SerializeField] private string _secondChoice;
    [SerializeField][Range(1, 2)] private int _validChoice;
    [SerializeField] private GameChoice _next;
    [SerializeField] private BonusPath _path;

    public string FirstChoice => _firstChoice;
    public string SecondChoice => _secondChoice;

    public void Chose(int choice)
    {
        if (choice == _validChoice)
            GameManager.Instance.AddGameChoice(_next);

        GameManager.Instance.OnWronglyAnswered.Invoke(_path);
    }
}
