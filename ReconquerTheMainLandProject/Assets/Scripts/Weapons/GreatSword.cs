using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSword : Weapon
{
    public override void Attack(Transform aimTransform, IDamageable projenitor)
    {
        GenereteProjectile(aimTransform, projenitor);
    }
}
