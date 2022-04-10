using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class TemporaryPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _hiddenGO;
    [SerializeField] private float _lastingTime;
    [SerializeField] private float _timer;

    private void Update()
    {
        if (_timer >= 0f)
            _timer -= Time.deltaTime;
        else
            Destroy(this);
    }

    public void SetTimer(GameObject collisionGameObject)
    {
        _hiddenGO = collisionGameObject;

        _timer = _lastingTime;
    }

    private void OnDestroy()
    {
        _hiddenGO.SetActive(true);
    }
}
