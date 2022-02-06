using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class DestroyParentStep : Step
{
    [SerializeField] private float destroyAfterSeconds;
    public override async UniTask Execute()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(destroyAfterSeconds));
        GameObject.Destroy(ParentTransform.gameObject);
    }
}