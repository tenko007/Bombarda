using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/DeleteBaseChilds", fileName = "DeleteBaseChilds")]
public class DeleteBaseChilds : Command
{
    private Transform[] _childTransforms;
    private Transform _targetTransform;
    [SerializeField] float deleteDelay = 0f;
    public override async UniTask Execute()
    {
        _targetTransform = TargetGameObject.transform;
        _childTransforms = TargetGameObject.GetComponentsInChildren<Transform>();
        DeleteAfter(deleteDelay); // do not await it
    }
    
    private async UniTask DeleteAfter(float seconds)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(seconds));
        foreach (var transform in _childTransforms)
        {
            if (transform != null && transform != _targetTransform)
                GameObject.Destroy(transform.gameObject);
        }
    }
}
