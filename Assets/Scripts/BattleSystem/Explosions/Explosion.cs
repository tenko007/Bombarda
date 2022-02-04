using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public abstract class Explosion : MonoBehaviour, IExplosion
{
    [SerializeField] private float baseDamage = 1f;
    [SerializeField] private float destroyDelay = 5f;
    public float BaseDamage => baseDamage;
    
    protected float damage;

    protected virtual void Init()
    {
        damage = BaseDamage;
        Explode();
    }

    private void Awake()
    {
        Init();
    }

    public virtual void Explode()
    {
        DamageAll();
        Destroy(this.gameObject, destroyDelay);
    }
    
    public abstract List<T> FindAll<T>();

    public virtual void DamageAll()
    {
        foreach (var damageable in FindAll<IDamageable>())
            damageable.Damage((int)damage);
    }
}