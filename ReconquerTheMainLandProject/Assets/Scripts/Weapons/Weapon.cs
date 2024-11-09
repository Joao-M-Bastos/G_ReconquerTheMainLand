using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] WeaponData _weaponData;

    public WeaponData WeaponData => _weaponData;

    public abstract void Attack(Transform aimTransform, IDamageable projenitor);

    protected void GenereteProjectile(Transform aimTransform, IDamageable projenitor)
    {
        GameObject instantiatedProjectile = Instantiate(_weaponData.ProjectilePrefab, aimTransform.position, aimTransform.rotation);

        instantiatedProjectile.GetComponent<Projectile>().Inicialize(_weaponData.Damage, _weaponData.ProjectileSpeed, _weaponData.ProjectrileLifeTime, projenitor);

    }
}
