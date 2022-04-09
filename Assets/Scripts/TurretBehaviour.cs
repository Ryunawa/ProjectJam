using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    // Feather prefab
    public GameObject fireBall;

    // Shooting variables
    private Transform _firePoint;

    // Shooting values
    private float _fireCooldown = 1.5f;
    private float _lastShot;
    private bool _isShooting = false;

    public bool IsShooting { set => _isShooting = value; }

    // Start is called before the first frame update
    void Start()
    {
        _firePoint = transform.Find("FirePoint");
        _lastShot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - _lastShot > _fireCooldown && _isShooting)
        {
            Instantiate(fireBall, _firePoint.position, _firePoint.rotation);
            _lastShot = Time.time;
        }
    }
}
