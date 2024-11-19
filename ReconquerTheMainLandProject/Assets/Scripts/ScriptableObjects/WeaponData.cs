using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon")]
public class WeaponData : ScriptableObject
{
    public string Name;
    public int Damage;
    public float AttacksDuration;
    public float AttackChargeTime;
    public float ProjectileSpeed;
    public float ProjectrileLifeTime;
    public GameObject WeaponPrefab;
    public GameObject ProjectilePrefab;
}
