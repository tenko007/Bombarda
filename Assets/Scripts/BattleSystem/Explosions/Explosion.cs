using System.Collections.Generic;
using BattleSystem.newExplosions;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Explosion")]
public class Explosion : SerializedScriptableObject, IExplosion
{
    private Transform parentTransform;
    public List<IExplosionStep> steps;
    public async UniTask Explode()
    {
        if (steps.Count == 0) return;
        foreach (var step in steps)
        {
            step.SetParentTransform(parentTransform);
            await step.Execute();
            //Debug.Log($"ExplosionStep {step.GetType()} completed!");
        }
    }

    public void SetParentTransform(Transform transform) =>
        this.parentTransform = transform;
}