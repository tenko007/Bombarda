using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IExplosion
{
    UniTask Explode();
    public void SetParentTransform(Transform transform);
}
