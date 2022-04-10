using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippableProjectile : Projectile
{
    [SerializeField] private bool isFlipped;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<TurretBehaviour>() || collision.GetComponent<SquirrelBehaviour>())
        {
            Destroy(collision.gameObject);
            Destroy(this);
        }
        
        if (collision.CompareTag("Player"))
        {
            CharacterController cc = collision.GetComponent<CharacterController>();
            bool facing = cc.IsFacing(transform.position);
            bool attacking = cc.IsAttacking;
            if (attacking && facing)
            {
                Debug.Log("let's flip !");
                Flip();
                return;
            }

            GetComponent<DamageDealer>().DealDamage(collision.GetComponent<PlayerLife>());
        }
        Destroy(gameObject);
    }

    private void Flip()
    {
        _rb.velocity = -transform.right * _speed;
        _rb.SetRotation(_rb.rotation-180);
        isFlipped = !isFlipped;
        Debug.Log("was flipped");
    }
}
