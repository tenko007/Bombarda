using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SphereDamage : DamageCommand
{
    [SerializeField] protected float radius;
    protected override List<Collider> FindAllCollidersNearby() 
    {
        return Physics.OverlapSphere(ParentTransform.position, radius).ToList();
    }
}