using UnityEngine;

public class FireBallBehaviour : MonoBehaviour
{
    public bool isPlayer;

    private float _speed = 30.0f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.velocity = transform.right * _speed;
    }

    // Check the GameObject's tag the projectile met
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        /*
        if (!isPlayer)
        {
            if (collision.CompareTag("Player"))        
            {
                collision.GetComponent<PlayerBehaviour>().Lose();
            }
        }
        */
    }
}