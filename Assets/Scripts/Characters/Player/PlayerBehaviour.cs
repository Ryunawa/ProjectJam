using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject magicProjectile;

    private Animator _animator;
    private Animator _shadowAnimator;
    private PlayerMovement _playerMovement;

    private Transform _magicalPoint;

    private void Start()
    {
        _playerMovement = this.GetComponent<PlayerMovement>();

        _magicalPoint = transform.Find("MagicalPoint");
        _animator = GetComponent<Animator>();
        //_shadowAnimator = GameObject.Find("PlayerShadow").GetComponent<Animator>();
    }

    public void Lose()
    {
        // Disable PlayerMovement and PlayerCombat
        _playerMovement.enabled = false;
        //_playerCombat.enabled = false;

        // Play death animation
        _animator.SetTrigger("Die");
        _shadowAnimator.SetTrigger("Die");
    }

    private void LaunchMagicalAttack()
    {
        Quaternion q = gameObject.transform.rotation;

        CharacterController cc = GetComponent<CharacterController>();
        
        if(!cc.Facing)
            q.SetFromToRotation(Vector3.left, Vector3.right);
        
        Instantiate(magicProjectile, _magicalPoint.position, q);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            respawnPoint = collision.gameObject;
        }
    }
}
