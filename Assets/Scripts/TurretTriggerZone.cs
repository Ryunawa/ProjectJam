using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTriggerZone : MonoBehaviour
{
    public float detectionRange = 20.0f;

    private SquirrelBehaviour _squirrelTurr;
    private TurretBehaviour _turrScript;
    private Transform _player;

    void Start()
    {
        _player = GameObject.Find("Player").transform;
        _turrScript = GetComponent<TurretBehaviour>();
        _squirrelTurr = GetComponent<SquirrelBehaviour>();
    }

    void Update()
    {
        float distance = Vector2.Distance(_player.transform.position, this.transform.position);
        if (distance <= detectionRange)
        {
            _turrScript.IsShooting = true;
            if(_squirrelTurr)
                _squirrelTurr.StartAnimationShooting(true);
        }
        else
        {
            _turrScript.IsShooting = false;
            if(_squirrelTurr)
                _squirrelTurr.StartAnimationShooting(false);

        }
    }
}
