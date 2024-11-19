using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    IDamageable _projenitor;
    Animator _animator;
    [SerializeField] int pircing;
    int _damage;
    float _speed;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Inicialize(int damage,float speed,float lifeTime, IDamageable projenitor)
    {
        _damage = damage;
        _speed = speed;

        _animator.SetFloat("LifeTime", 1/lifeTime);

        _projenitor = projenitor;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position  += _speed * Time.fixedDeltaTime * transform.right;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.TryGetComponent(out IDamageable characterHit))
        {
            if (characterHit == _projenitor)
                return; 

            characterHit.TakeDamage(_damage);
            characterHit.TakeKnockback();
            pircing--;

            if (pircing <= 0)
                DestroyProjectile();
        }
    }

    public void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
