using System.Collections.Generic;
using BattleSystem.Explosions.Steps.Abstractions;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Explosion")]
public class Algorithm : SerializedScriptableObject, IAlgorithm
{
    private Transform parentTransform;
    public List<ICommand> steps;
    public async UniTask Explode()
    {
        if (steps.Count == 0) return;
        foreach (var step in steps)
        {
            step.SetParentTransform(parentTransform);
            await step.Execute();
            //Debug.Log($"Step {step.GetType()} completed!");
        }
    }

    public void SetParentTransform(Transform transform) =>
        this.parentTransform = transform;
}