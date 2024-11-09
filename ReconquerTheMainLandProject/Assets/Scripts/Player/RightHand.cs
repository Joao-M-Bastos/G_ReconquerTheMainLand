using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    [SerializeField] Transform _projectileSpawn;
    [SerializeField] IDamageable _projectorIDamageble;

    [SerializeField] Weapon _currentWeapon;


    public void Attack(out float attackSpeed)
    {
        attackSpeed = 1/_currentWeapon.WeaponData.AttacksDuration;
        _currentWeapon.Attack(_projectileSpawn, _projectorIDamageble);
    }
}
