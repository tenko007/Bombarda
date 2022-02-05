using UnityEngine;

public class SphereDamage : DamageStep
{
    [SerializeField] private float radius;
    protected override Collider[] FindAllCollidersNearby()
    {
        return Physics.OverlapSphere(ParentTransform.position, radius);
    }
}