using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/DestroyStep", fileName = "DestroyStep")]
    public class DestroyStep : Step
    {
        [SerializeField] private float destroyAfterSeconds;
        public override async UniTask Execute()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(destroyAfterSeconds));
            Destroy(ParentTransform.gameObject);
        }
    }
}