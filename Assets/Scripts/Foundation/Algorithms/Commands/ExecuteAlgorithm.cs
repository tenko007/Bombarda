using Cysharp.Threading.Tasks;
using UnityEngine;

public class ExecuteAlgorithm : Command
{
    [SerializeField] private Algorithm _algorithm;
    public override async UniTask Execute()
    {
        _algorithm.SetParentTransform(ParentTransform);
        await _algorithm.Explode();
    }
}
