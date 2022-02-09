using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/DestroyParent", fileName = "DestroyParent")]
public class DestroyParent : Command
{
    [SerializeField] private float destroyAfterSeconds;
    public override async UniTask Execute()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(destroyAfterSeconds));
        GameObject.Destroy(ParentTransform.gameObject);
    }
}