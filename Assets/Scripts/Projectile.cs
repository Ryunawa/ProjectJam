using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isPlayer;

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
            GetComponent<DamageDealer>().DealDamage(collision.GetComponent<PlayerLife>());
        }
        Destroy(gameObject);
    }
}