using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

public class GameManager : MonoBehaviour
{
    #region Singleton

    private static GameManager _instance;
        
    public static GameManager Instance => _instance;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            _instance.Setup();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion
    
    public GameObject RespawnPoint;
    public GameObject Player;
    public GameObject Platform;
    [SerializeField] private UIControl _uiControl;

    void Start()
    {
        Player.GetComponent<Transform>();
        RespawnPoint.GetComponent<Transform>();
    }

    public void Respawn()
    {
        Player.transform.position = RespawnPoint.transform.position;
    }

    private void Setup() {}
    
    public void AddGameChoice(GameChoice next) => _uiControl.AddChoice(next);

    public void AddGameDialogs(GameDialog[] dialogs) => _uiControl.AddDialogs(dialogs);
    
    public void AddGameDialog(GameDialog gameDialog)
    {
        GameDialog[] dialogs = { gameDialog };
        
        AddGameDialogs(dialogs);
    }

    public void Light(int index, bool lightUp = true) => _uiControl.Light(index, lightUp);

    public void AddGameTexts(GameText[] gameTexts) => _uiControl.AddTexts(gameTexts);

    public void UpdateLifeDisplay(int lifePoints) => _uiControl.UpdateLifeDisplay(lifePoints);

    public void NextText() => _uiControl.NextText();

    public void AddGameText(GameText next)
    {
        GameText[] texts = { next };
        AddGameTexts(texts);
    }
}
