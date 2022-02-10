using Cysharp.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(menuName = "Commands/HideMesh", fileName = "HideMesh")]
public class HideMesh : Command
{
    public override async UniTask Execute()
    {
        MeshRenderer mesh = TargetGameObject.GetComponent<MeshRenderer>();
        if (mesh != null)
            GameObject.Destroy(mesh);
    }
}
