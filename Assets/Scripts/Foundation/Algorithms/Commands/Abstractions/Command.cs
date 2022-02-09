using BattleSystem.Explosions.Steps.Abstractions;
using Cysharp.Threading.Tasks;
using UnityEngine;

public abstract class Command : ICommand
{
    public abstract UniTask Execute();
    public Transform ParentTransform { get; private set; }
    public void SetParentTransform(Transform transform)
        => ParentTransform = transform;
}
