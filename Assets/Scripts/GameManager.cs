using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private PlatformManager _platformManager;

    public UnityEvent<PlatformBehaviour, float> GetPlatformEventDestroyed => _platformManager.onPlatformDestroyed;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void PlatformRespawn(Vector2 transform)
    {
        
    }
}
