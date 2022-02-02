using UnityEngine;

public class SmartSphereExplosion : SphereExplosion
{
    [SerializeField] private float raduis;
    public float Raduis => raduis;

    public override void Explode()
    {
        IncreaseDamage();
        base.Explode();
    }

    protected virtual void IncreaseDamage() // TODO move somewhere?
    {
        Collision collisionInfo = GetComponent<Collision>();
        int contactsCount = collisionInfo.contacts.Length;
        float coefficient = contactsCount / 10f;
        damage *= (1 + coefficient);
    }
}