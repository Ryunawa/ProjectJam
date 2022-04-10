using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private float _timeBetweenRegenTicks;
    [SerializeField] private float _timeSinceLastRegenTick;

    [SerializeField] private int _startLifePoints;
    [SerializeField] private int _lifePoints;
    [SerializeField] private int _maxLifePoints;

    private void Start()
    {
        _lifePoints = _startLifePoints;
    }

    private void Update()
    {
        _timeSinceLastRegenTick += Time.deltaTime;

        if (_timeBetweenRegenTicks >= _timeSinceLastRegenTick) return;
        _timeSinceLastRegenTick = 0f;
            
        if(_lifePoints < _maxLifePoints)
            TakeDamage(-1);
    }

    public void TakeDamage(int i)
    {
        _lifePoints -= i;

        if (_lifePoints > _maxLifePoints)
            _lifePoints = _maxLifePoints;

        if (_lifePoints <= 0)
        {
            _lifePoints = 0;
            GameManager.Instance.Respawn();
            //GetComponent<PlayerBehaviour>().Lose();
        }
        
        GameManager.Instance.UpdateLifeDisplay(_lifePoints);
    }
}