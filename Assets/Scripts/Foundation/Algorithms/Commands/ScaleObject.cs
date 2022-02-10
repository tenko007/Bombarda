using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/ScaleObject", fileName = "ScaleObject")]
public class ScaleObject : Command
{
    [SerializeField] private float scale = 1f;
    public async override UniTask Execute() =>
        TargetGameObject.transform.localScale *= scale;
}