using BattleSystem.Explosions.Steps.Abstractions;
using Cysharp.Threading.Tasks;
using UnityEngine;

public abstract class Command : ScriptableObject, ICommand
{
    public abstract UniTask Execute();
    public GameObject TargetGameObject { get; private set; }
    public void SetTargetGameObject(GameObject gameObject)
        => TargetGameObject = gameObject;
}