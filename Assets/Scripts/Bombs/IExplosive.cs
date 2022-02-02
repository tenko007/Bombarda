using UnityEngine;

public interface IExplosive
{
    GameObject Explosion { get; }
    void Explode();
}