using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Delay : ExplosionStep
{
    [SerializeField] private float delaySeconds;
    public override async UniTask Execute() =>
        await UniTask.Delay(TimeSpan.FromSeconds(delaySeconds));
}
