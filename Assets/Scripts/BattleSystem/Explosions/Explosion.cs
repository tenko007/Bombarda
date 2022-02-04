using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[Serializable] //TODO Do i need it?
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

    public abstract List<IDamageable> FindAllDamageable();

    public virtual void DamageAll()
    {
        foreach (var damageable in FindAllDamageable())
            damageable.Damage((int)damage);
    }
}