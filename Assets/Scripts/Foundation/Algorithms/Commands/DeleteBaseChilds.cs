using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/DeleteBaseChilds", fileName = "DeleteBaseChilds")]
public class DeleteBaseChilds : Command
{
    private Transform[] _transforms;
    [SerializeField] float deleteDelay = 0f;
    public override async UniTask Execute()
    {
        _transforms = ParentTransform.gameObject.GetComponentsInChildren<Transform>();
        DeleteAfter(deleteDelay); // do not await it
    }
    
    private async UniTask DeleteAfter(float seconds)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(seconds));
        foreach (var transform in _transforms)
        {
            if (transform != null && transform != ParentTransform)
                GameObject.Destroy(transform.gameObject);
        }
    }
}
