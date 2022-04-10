using System.Collections.Generic;
using UnityEngine;

public class SawBehaviour : MonoBehaviour
{
    public Transform[] waypointsFirstPattern;
    
    private List<Transform[]> _sawPattern = new List<Transform[]>();
    private Transform _target;
    private int _nextWaypoint;

    [SerializeField]
    private float _speed = 20.0f;
    private float _rotSpeed = -360.0f;
    private bool _isEnabled = true;

    [SerializeField]
    private Sprite _spriteOff;

    #region Unity methods
    // Start is called before the first frame update
    private void Start()
    {
        _sawPattern.Add(waypointsFirstPattern);

        _target = waypointsFirstPattern[0];
    }

    // Update is called once per frame
    private void Update()
    {
        if (_isEnabled)
        {
            SawMovement();
            transform.Rotate(0, 0, _rotSpeed * Time.deltaTime);
        }
    } 
    #endregion
    
    #region Private methods (Movement)
    private void SawMovement()
    {
        Vector3 dir = _target.position - transform.position;                            // Give to the saw his direction to reach the next target
        transform.Translate(dir.normalized * _speed * Time.deltaTime, Space.World);      // Move the saw until the next target

        if (Vector3.Distance(transform.position, _target.position) < 0.01f)             // If the saw is near to her current target, change it to the next
        {
            _nextWaypoint = (_nextWaypoint + 1) % (waypointsFirstPattern.Length);       // Allow to restart to the first index in the list when the last index is reach
            _target = waypointsFirstPattern[_nextWaypoint];                             // Change the target
        }
    }
    #endregion

    #region Public methods
    public void GetHitByPlayer()
    {
        if (_nextWaypoint == 0)
        {
            _rotSpeed *= -1;
            _target = _sawPattern[1][0];
            _nextWaypoint = -1;
        }
    }

    /*
     public void Disable()
    {
        this.GetComponent<CircleCollider2D>().enabled = false;
        this.GetComponent<SpriteMask>().enabled = false;
        this.GetComponent<SpriteRenderer>().sprite = _spriteOff;
        _isEnabled = false;

    }
    */
    #endregion

    // Check if the saw shit the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<DamageDealer>().DealDamage(collision.GetComponent<PlayerLife>());
        }
    }
}
