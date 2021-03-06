using UnityEngine;

public class SquirrelBehaviour : TurretBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        _firePoint = transform.Find("FirePoint");
        _lastShot = Time.time;
        anim = GetComponent<Animator>();
    }

    public void StartAnimationShooting(bool isShootingAnim)
    {
        anim.SetBool("isShooting", isShootingAnim);
    }
    
    public void ShootArrow()
    {
        Instantiate(_projectile, _firePoint.position, _firePoint.rotation);
        _lastShot = Time.time;
    }
}