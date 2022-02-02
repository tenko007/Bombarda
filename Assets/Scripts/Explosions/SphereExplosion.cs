using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SphereExplosion : Explosion
{
    [SerializeField] private float raduis;
    public float Raduis => raduis;    
    private void Start()
    {
        transform.localScale *= Raduis;
    }
}