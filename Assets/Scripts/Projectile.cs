using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class Projectile : MonoBehaviour
{
    [SerializeField] protected float _speed = 30.0f;
    protected Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.velocity = transform.right * _speed;
    }

    protected abstract void OnTriggerEnter2D(Collider2D collision);
}