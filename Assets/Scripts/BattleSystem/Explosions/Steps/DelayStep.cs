using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace BattleSystem.newExplosions
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Steps/DelayStep", fileName = "DelayStep")]
    public class DelayStep : Step
    {
        [SerializeField] private float delaySeconds;
        public override async UniTask Execute() =>
            await UniTask.Delay(TimeSpan.FromSeconds(delaySeconds));
    }
}