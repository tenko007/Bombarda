using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Delay : Command
{
    [SerializeField] private float delaySeconds;
    public override async UniTask Execute() =>
        await UniTask.Delay(TimeSpan.FromSeconds(delaySeconds));
}