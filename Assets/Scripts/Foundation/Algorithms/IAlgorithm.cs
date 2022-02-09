using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IAlgorithm
{
    UniTask Execute();
    public void SetParentTransform(Transform transform);
}
