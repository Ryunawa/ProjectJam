using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region Singleton

    private static GameManager _instance;
        
    public static GameManager Instance => _instance;

    public GameObject respawnPoint;
    public GameObject player;

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

    [SerializeField] private UIControl _uiControl;
        
    void Start()
    {
        player.GetComponent<Transform>();
        respawnPoint.GetComponent<Transform>();
    }

    public void Respawn()
    {
        player.transform.position = respawnPoint.transform.position;
    }

    private void Setup() {}

    public void AddDialogs(GameDialog[] dialog)
    {
        _uiControl.AddDialog(dialog);
    }
}
