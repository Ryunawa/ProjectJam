using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject MenuEnd;

    private Animator _animator;
    private Animator _shadowAnimator;
    private PlayerMovement _playerMovement;
    //private PlayerCombat _playerCombat;
    private static int _endCount;

    private void Start()
    {
        _playerMovement = this.GetComponent<PlayerMovement>();
        //_playerCombat = this.GetComponent<PlayerCombat>();

        _animator = this.GetComponent<Animator>();
        _shadowAnimator = GameObject.Find("PlayerShadow").GetComponent<Animator>();

        _endCount = 0;
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

    private void OnDeathAnimationEnd()
    {
        // When animation ends, reset player position
        transform.position = respawnPoint.transform.position;

        _playerMovement.enabled = true;
        //_playerCombat.enabled = true;
    }

    private void Win()
    {
        _playerMovement.enabled = false;
        //_playerCombat.enabled = false;
    }

    /*
    private void OnAnimationWinEnd()
    {
        // Open end menu
        MenuEnd.GetComponent<MenuEnd>().MenuEndWin();
    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            respawnPoint = collision.gameObject;
        }
    }
}
