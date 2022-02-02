using UnityEngine;

public class CrossExplosion : Explosion
{    
    [SerializeField] private float length;
    public float Length => length;
    protected Collider explosionArea;

    private void Awake()
    {
        explosionArea = GetComponent<Collider>();
    }
    
    // TODO
}