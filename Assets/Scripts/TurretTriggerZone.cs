using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTriggerZone : MonoBehaviour
{
    public float detectionRange = 20.0f;
   
    private TurretBehaviour _turrScript;
    private Transform _player;

    private void Start()
    {
        _player = GameObject.Find("Player").transform;
        _turrScript = this.GetComponent<TurretBehaviour>();
    }

    private void Update()
    {
        float distance = Vector2.Distance(_player.transform.position, this.transform.position);
        if (distance <= detectionRange)
            _turrScript.IsShooting = true;
        else
            _turrScript.IsShooting = false;
    }
}
