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

    public override List<T> FindAll<T>()
    {
        List<T> TList = new List<T>();
        foreach (var contact in FindAllCollidersNearby())
        {
            var TComponent = contact.gameObject.GetComponent<T>();
            if (TComponent != null)
                TList.Add(TComponent);
        }

        return TList;
    }

    protected Collider[] FindAllCollidersNearby()
    {
        if (CollidersNearbyCashed != null)
            return CollidersNearbyCashed;
        CollidersNearbyCashed = Physics.OverlapSphere(transform.position, radius);
        return CollidersNearbyCashed;
    }
}