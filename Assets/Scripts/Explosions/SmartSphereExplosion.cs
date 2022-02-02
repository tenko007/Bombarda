using UnityEngine;

public class SmartSphereExplosion : SphereExplosion
{
    [SerializeField] private float damageIncreaseCoeffPercent = 10f;
    
    public override void Explode()
    {
        IncreaseDamage();
        base.Explode();
    }

    protected virtual void IncreaseDamage()
    {
        int contactsCount = FindAllCollidersNearby().Length;
        float coefficient = contactsCount * damageIncreaseCoeffPercent/100;
        damage *= (1 + coefficient);
    }
}