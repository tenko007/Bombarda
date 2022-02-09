using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class DestroyObject : Command
{
    [SerializeField] private GameObject objectToDestroy;
    [SerializeField] private float destroyAfterSeconds;
    public override async UniTask Execute()
    {
        //await UniTask.Delay(TimeSpan.FromSeconds(destroyAfterSeconds));
        GameObject.Destroy(objectToDestroy, destroyAfterSeconds);
    }
}