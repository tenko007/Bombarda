using Cysharp.Threading.Tasks;
using UnityEngine;

public class ScaleObject : Command
{
    [SerializeField] private float scale;
    public async override UniTask Execute() =>
        ParentTransform.localScale *= scale;
}