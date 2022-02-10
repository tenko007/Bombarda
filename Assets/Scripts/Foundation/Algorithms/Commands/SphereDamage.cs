using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/SphereDamage", fileName = "SphereDamage")]
public class SphereDamage : DamageCommand
{
    [SerializeField] protected float radius;
    protected override List<Collider> FindAllCollidersNearby() =>
        Physics.OverlapSphere(TargetGameObject.transform.position, radius).ToList();
}