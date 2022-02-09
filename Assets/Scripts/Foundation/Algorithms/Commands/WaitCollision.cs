using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/WaitCollision", fileName = "WaitCollision")]
public class WaitCollision : Command
{
    public override async UniTask Execute()
    {
        var collisionTrigger = ParentTransform.GetAsyncCollisionEnterTrigger();
        var collisions = collisionTrigger.OnCollisionEnterAsync();
        await collisions;
    }
}