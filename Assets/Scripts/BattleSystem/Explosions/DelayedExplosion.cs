using System.Collections;
using UnityEngine;

public class DelayedExplosion : SphereExplosion
{
    [SerializeField] private float explosionDelay;
    public float ExplosionDelay => explosionDelay;

    public override void Explode()
    {
        StartCoroutine(WaitAndExplode());
    }

    private IEnumerator WaitAndExplode()
    {
        yield return new WaitForSeconds(explosionDelay);
        base.Explode();
    }
}