using System.Collections.Generic;
using UnityEngine;

public class CrossExplosion : Explosion
{    
    [SerializeField] private float length;
    public float Length => length;

    public override List<IDamageable> FindAllDamageable()
    {
        throw new System.NotImplementedException();        
        // TODO Raycast - throw it in four directions
    }
}