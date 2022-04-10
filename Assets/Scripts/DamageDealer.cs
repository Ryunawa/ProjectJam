using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] [Range(1,4)] private int _damage;

    public void DealDamage(PlayerLife life) => life.TakeDamage(_damage);
}