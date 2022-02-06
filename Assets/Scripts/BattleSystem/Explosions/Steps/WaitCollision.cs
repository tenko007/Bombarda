using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Triggers;

public class WaitCollision : Step
{
    public override async UniTask Execute()
    {
        var collisionTrigger = ParentTransform.GetAsyncCollisionEnterTrigger();
        var collisions = collisionTrigger.OnCollisionEnterAsync();
        await collisions;
    }
}