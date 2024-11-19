using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    [SerializeField] Transform _projectileSpawn;
    [SerializeField] IDamageable _projectorIDamageble;

    [SerializeField] Weapon _currentWeapon;


    public void Attack(out float attackDuration, out float chargeDuration)
    {

        attackDuration = _currentWeapon.WeaponData.AttacksDuration;
        chargeDuration = _currentWeapon.WeaponData.AttackChargeTime;

        Invoke("WeaponAttack", chargeDuration);
    }

    public void WeaponAttack()
    {
        _currentWeapon.Attack(_projectileSpawn, _projectorIDamageble);
    }
}
