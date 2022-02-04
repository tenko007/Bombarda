using BattleSystem.Explosions.Steps.Abstractions;
using UnityEngine;

public interface IExplosionStep : IStep
{
    public Transform ParentTransform { get; }
    public void SetParentTransform(Transform transform);
}
