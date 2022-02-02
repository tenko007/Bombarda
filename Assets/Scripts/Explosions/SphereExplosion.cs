using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SphereExplosion : Explosion
{
    [SerializeField] private float radius = 5f;
    public float Radius => radius;
    protected Collider[] CollidersNearbyCashed; 
    protected override void Init()
    {
        transform.localScale *= radius;
        base.Init();
    }

    protected Collider[] FindAllCollidersNearby()
    {
        if (CollidersNearbyCashed != null)
            return CollidersNearbyCashed;
        //Physics.OverlapSphereNonAlloc(transform.position, radius, CollidersNearbyCashed);
        CollidersNearbyCashed = Physics.OverlapSphere(transform.position, radius);
        return CollidersNearbyCashed;
    }

    public override List<IDamageable> FindAllDamageable()
    {
        List<IDamageable> damageables = new List<IDamageable>();
        foreach (var contact in FindAllCollidersNearby())
        {
            var damageable = contact.gameObject.GetComponent<IDamageable>();
            if (damageable != null)
                damageables.Add(damageable);
        }

        return damageables;
    }
}