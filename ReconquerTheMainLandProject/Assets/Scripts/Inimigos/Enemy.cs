using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] CharacterData enemyData;

    protected int DamageTaken;

    public void TakeDamage(int damage)
    {
        Debug.Log("a");
        DamageTaken += damage;
        TryDie();
    }

    public void TryDie()
    {
        if (DamageTaken >= enemyData.MaxLife)
            Die();
    }

    public abstract void Die();

    public void DestroyGameObject()
    {
        OnGameObjectDestroyed();
        Destroy(gameObject);
    }

    protected abstract void OnGameObjectDestroyed();

    public void TakeKnockback()
    {

    }
}
