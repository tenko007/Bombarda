using System.Collections;
using UnityEngine;

public class BombWithTimer : MonoBehaviour, IExplosive
{
    [SerializeField] private float timeToExplode;
    [SerializeField] private Explosion explosion;
    [SerializeField] private float baseDamage;
    public IExplosion Explosion => explosion;
    
    private void Start()
    {
        StartCoroutine(WaitForExplode(timeToExplode)); // TODO stop coroutine on destroy?
    }

    void OnCollisionEnter(Collision collision) => Explode();

    public void Explode()
    {
        var thisTransform = this.transform;
        GameObject newExplosion = Instantiate(explosion.gameObject,
            thisTransform.position, Quaternion.identity, thisTransform);
        newExplosion.GetComponent<Explosion>().Explode(); // TODO change order?
        Destroy(gameObject); // TODO change order?
    }

    IEnumerator WaitForExplode(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Explode();
    }
}