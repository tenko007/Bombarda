using Cysharp.Threading.Tasks;
using UnityEngine;

public class ScaleObject : ExplosionStep
{
    [SerializeField] private float scale;
    public async override UniTask Execute() =>
        ParentTransform.localScale *= scale;
}