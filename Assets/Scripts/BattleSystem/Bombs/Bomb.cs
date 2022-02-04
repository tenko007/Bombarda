using UnityEngine;

public abstract class Bomb : MonoBehaviour, IExplosive
{
    [SerializeField] private GameObject explosion;
    public GameObject Explosion => explosion;
    public virtual void Explode()
    {
        GameObject newExplosionGO = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}