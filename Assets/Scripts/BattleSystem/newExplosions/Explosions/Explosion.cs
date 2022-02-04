using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Explosions/Explosion")]
    public class Explosion : ScriptableObject, IExplosion//, IStep
    {
        private Transform parentTransform;
        public List<Step> steps;
        public async UniTask Explode()
        {
            if (steps.Count == 0) return;
            foreach (var step in steps)
            {
                step.SetParentTransform(parentTransform);
                await step.Execute();
                Debug.Log($"Step {step.name} completed!");
            }
        }

        public void SetParentTransform(Transform transform) =>
            this.parentTransform = transform;

        public async UniTask Execute() =>
            await Explode();
    }
}