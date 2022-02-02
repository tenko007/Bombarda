using System;
using System.Collections;
using UnityEngine;

public class BombWithTimer : MonoBehaviour, IExplosive
{
    [SerializeField] private float timeToExplode;
    [SerializeField] private GameObject explosion;
    [SerializeField] private float baseDamage;
    public GameObject Explosion => explosion;

    private void Start()
    {
        StartCoroutine(WaitForExplode(timeToExplode));
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    void OnCollisionEnter(Collision collision) => Explode();



    public void Explode()
    {
        GameObject newExplosionGO = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator WaitForExplode(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Explode();
    }
}