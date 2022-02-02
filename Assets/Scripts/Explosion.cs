using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[Serializable] //TODO Do i need it?
public abstract class Explosion : MonoBehaviour, IExplosion
{
    [SerializeField] private float baseDamage;
    
    public float BaseDamage => baseDamage;
    
    protected float damage;

    private void Awake()
    {
        damage = BaseDamage;
    }

    private void Start()
    {
        Explode();
    }

    public virtual void Explode()
    {
        DamageAll();
        Destroy(this.gameObject);
    }

    public virtual List<IDamageable> FindAllDamageable()
    {
        List<IDamageable> damageables = new List<IDamageable>();
        //var contacts = gameObject.GetComponent<Collision>().contacts;
        var contacts = Physics.OverlapSphere(transform.position, 5);
        foreach (var contact in contacts)
        {
            var damageable = contact.gameObject.GetComponent<IDamageable>();
            if (damageable != null)
                damageables.Add(damageable);
        }

        return damageables;
    }

    public virtual void DamageAll()
    {
        foreach (var damageable in FindAllDamageable())
            damageable.Damage((int)damage);
    }
}