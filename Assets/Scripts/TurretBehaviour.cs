using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    // Feather prefab
    public GameObject projectile;

    // Shooting variables
    private Transform _firePoint;

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
            if(projectile)
                Debug.Log(name + " " + projectile.name);
            else
                Debug.Log("HA");
            
            if(_firePoint)
                Debug.Log(_firePoint);
            else
                Debug.Log("AH");
            
            Instantiate(projectile, _firePoint.position, _firePoint.rotation);
            _lastShot = Time.time;
        }
    }
}
