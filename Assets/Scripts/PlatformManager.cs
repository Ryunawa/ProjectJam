using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class PlatformManager : MonoBehaviour
{
    #region Singleton
    
    private static PlatformManager _instance;
    
    public static PlatformManager Instance => _instance;

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

    private void Setup()
    {
        Debug.Log("je setup");
        respawnDelay = new Dictionary<PlatformBehaviour, float>();
        onPlatformDestroyed = new UnityEvent<PlatformBehaviour, float>();
        onPlatformDestroyed.AddListener(AddPlatformDelay);
    }

    public UnityEvent<PlatformBehaviour, float> onPlatformDestroyed;
    private Dictionary<PlatformBehaviour, float> respawnDelay;
    
    private void AddPlatformDelay(PlatformBehaviour platform, float delay)
    {
        if(respawnDelay.ContainsKey(platform)) return;
        Debug.Log("ajoutons un delai");

        platform.gameObject.SetActive(false);
        respawnDelay.Add(platform, delay);
    }

    private void Update()
    {
        float deltaTime = Time.deltaTime;

        if(respawnDelay is null) Debug.Log("pardon ?");
        
        PlatformBehaviour[] keys = respawnDelay.Keys.ToArray();
        
        foreach (PlatformBehaviour platform in keys)
        {
            respawnDelay[platform] -= deltaTime;
            
            if (!(respawnDelay[platform] <= 0)) continue;
            platform.gameObject.SetActive(true);
            respawnDelay.Remove(platform);
        }
    }
}
