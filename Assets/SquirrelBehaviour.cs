using UnityEngine;

public class SquirrelBehaviour : TurretBehaviour
{
    // Shooting variables
    private Transform _firePoint;

    // Shooting values
    private float _fireCooldown = 2.0f;
    private float _lastShot;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        _firePoint = transform.Find("FirePoint");
        _lastShot = Time.time;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartAnimationShooting(bool isShootingAnim)
    {
        anim.SetBool("isShooting", isShootingAnim);
    }
    
    public void ShootArrow()
    {
        Instantiate(projectile, _firePoint.position, _firePoint.rotation);
        _lastShot = Time.time;
    }
}