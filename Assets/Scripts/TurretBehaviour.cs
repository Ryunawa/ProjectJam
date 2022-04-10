using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    // Feather prefab
    [SerializeField] protected GameObject _projectile;

    // Shooting variables
    protected Transform _firePoint;

    // Shooting values
    protected float _fireCooldown = 1.5f;
    protected float _lastShot;
    private bool _isShooting = false;

    public bool IsShooting { set => _isShooting = value; }

    // Start is called before the first frame update
    void Start()
    {
        _firePoint = GetComponentInChildren<Transform>();
        _lastShot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - _lastShot > _fireCooldown && _isShooting)
        {   
            Instantiate(_projectile, _firePoint.position, _firePoint.rotation);
            _lastShot = Time.time;
        }
    }
}
