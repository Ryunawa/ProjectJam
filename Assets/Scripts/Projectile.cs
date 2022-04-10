using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isFlipped;

    public float _speed = 30.0f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.velocity = transform.right * _speed;
    }

    // Check the GameObject's tag the projectile met
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Attacking player");
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