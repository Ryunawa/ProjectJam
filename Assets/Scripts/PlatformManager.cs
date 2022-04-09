using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class PlatformManager : MonoBehaviour
{
    public UnityEvent<PlatformBehaviour, float> onPlatformDestroyed;
    private Dictionary<PlatformBehaviour, float> respawnDelay;

    private void Awake()
    {
        onPlatformDestroyed = new UnityEvent<PlatformBehaviour, float>();
        onPlatformDestroyed.AddListener(AddPlatformDelay);
        respawnDelay = new Dictionary<PlatformBehaviour, float>();
    }

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
