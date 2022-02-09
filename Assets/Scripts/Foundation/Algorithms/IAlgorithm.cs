using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IAlgorithm
{
    UniTask Explode();
    public void SetParentTransform(Transform transform);
}
